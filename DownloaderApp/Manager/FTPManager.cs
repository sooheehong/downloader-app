using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace DownloaderApp
{
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
            var isDirectory = true;

            // 처음(메인) 실행 시 일부 필드 초기화
            if (isFirst)
            {
                url = remoteURL + url;
                saveFiles = new List<string>();
                tasks = new List<Task>();

                // 폴더가 아닌지 체크
                if (url.LastIndexOf("/") != url.Length - 1)
                {
                    isDirectory = false;
                    // 폴더가 아닐 경우 폴더로 url 재설정
                    url = url.Substring(0, url.LastIndexOf("/") + 1);
                }
            }

            SubFiles sub = GetSubFileList(url);

            // 폴더라면 하위 폴더도 다운로드
            if (isDirectory)
            {
                foreach (string item in sub.Directories)
                {
                    string newLocalPath = Path.Combine(localPath, item);
                    if (!Directory.Exists(newLocalPath))
                    {
                        Directory.CreateDirectory(newLocalPath);
                    }
                    FtpDownload(url + item + "/", newLocalPath);
                }
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
