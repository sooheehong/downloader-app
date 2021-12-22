using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DownloaderApp
{
    public enum EDownloadType
    {
        None = 0,
        Directory = 1,
        File = 2
    }
    internal class SubFiles
    {
        public List<string> Files { get; set; } = new List<string>();
        public List<string> Directories { get; set; } = new List<string>();
    }

    class FTPManager
    {
        private string id;
        private string pw;
        private string host;
        private int port;
        private string remoteURL => "ftp://" + host + ":" + port;
        private List<string> saveFiles;
        private List<Task> tasks;

        public FTPManager(string id, string pw, string host, int port)
        {
            this.id = id;
            this.pw = pw;
            this.host = host;
            this.port = port == 0 ? 21 : port;
        }

        private FtpWebResponse Connect(string url, string method)
        {
            FtpWebRequest request = WebRequest.Create(url) as FtpWebRequest;
            request.Method = method;
            request.Credentials = new NetworkCredential(id, pw);

            return request.GetResponse() as FtpWebResponse;
        }

        public bool IsConnect()
        {
            try
            {
                Connect(remoteURL, WebRequestMethods.Ftp.ListDirectory);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> FtpDownload(string url, string localPath, bool isFirst = false)
        {
            var sub = new SubFiles();
            var downloadType = EDownloadType.Directory;

            // 처음(메인) 실행 시 일부 필드 초기화
            if (isFirst)
            {
                url = remoteURL + url;
                saveFiles = new List<string>();
                tasks = new List<Task>();

                downloadType = GetDownloadType(url);
                if (downloadType == EDownloadType.None)
                {
                    throw new Exception("해당 경로의 파일(디렉토리)이 없습니다");
                }
                else if (downloadType == EDownloadType.Directory)
                {
                    if (url[url.Length - 1] != '/')
                    {
                        url += "/";
                    }
                    var split = url.Split("/");
                    var name = split[split.Length - 2];
                    localPath = Path.Combine(localPath, name);

                    if (Directory.Exists(localPath))
                    {
                        Directory.Delete(localPath, true);
                    }

                    Directory.CreateDirectory(localPath);
                }
                else
                {
                    var split = url.Split("/");
                    var name = split[split.Length - 1];

                    // 다운로드 목록에 파일 추가 및 url 재설정
                    sub.Files.Add(name);
                    url = url.Substring(0, url.LastIndexOf("/") + 1);
                }
            }

            if (downloadType == EDownloadType.Directory)
            {
                sub = GetSubFileList(url);
            }

            // 하위 폴더 다운로드
            foreach (string item in sub.Directories)
            {
                string newLocalPath = Path.Combine(localPath, item);
                if (!Directory.Exists(newLocalPath))
                {
                    Directory.CreateDirectory(newLocalPath);
                }
                FtpDownload(url + item + "/", newLocalPath);
            }

            // 파일 다운로드
            foreach (string item in sub.Files)
            {
                string newLocalPath = Path.Combine(localPath, item);
                tasks.Add(Task.Factory.StartNew(() => { DownloadFile(url, item, newLocalPath); }));
            }

            if (isFirst)
            {
                Task.WaitAll(tasks.ToArray());
            }

            return saveFiles;
        }

        private EDownloadType GetDownloadType(string url)
       {
            FtpWebRequest request = WebRequest.Create(url) as FtpWebRequest;
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.Credentials = new NetworkCredential(id, pw);

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        return EDownloadType.File;
                    }
                }
            }
            catch (WebException ex)
            {
                var response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    return EDownloadType.None;
                }
                return EDownloadType.Directory;
            }
        }

        private SubFiles GetSubFileList(string url)
        {
            SubFiles list = new SubFiles();

            using (FtpWebResponse res = Connect(url, WebRequestMethods.Ftp.ListDirectoryDetails))
            {
                using (Stream stream = res.GetResponseStream())
                {
                    using (StreamReader rd = new StreamReader(stream))
                    {
                        while (true)
                        {
                            string buf = rd.ReadLine();
                            if (string.IsNullOrWhiteSpace(buf))
                            {
                                break;
                            }

                            string name = buf.Substring(buf.LastIndexOf(" ") + 1);
                            if (buf[0] == '-')
                            {
                                list.Files.Add(name);
                            }
                            else
                            {
                                list.Directories.Add(name);
                            }
                        }
                    }
                }
            }
            
            return list;
        }


        private void DownloadFile(string url, string item, string localPath)
        {
            using (FtpWebResponse res = Connect(url + item, WebRequestMethods.Ftp.DownloadFile))
            {
                using (Stream stream = res.GetResponseStream())
                {
                    using (FileStream fs = File.Create(localPath))
                    {
                        stream.CopyTo(fs);
                        saveFiles.Add(url + item);
                    }
                }
            }

        }
    }
}
