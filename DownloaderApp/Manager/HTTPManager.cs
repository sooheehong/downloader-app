using System.IO;
using System.Net;

namespace DownloaderApp
{
    class HTTPManager
    {
        private static WebResponse Connect(string url, string method)
        {
            var request = WebRequest.Create(url) as HttpWebRequest;

            request.Method = method;

            return request.GetResponse() as HttpWebResponse;
        }

        public static bool IsWebExists(string url)
        {
            try
            {
                Connect(url, WebRequestMethods.Http.Head);
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }

        public static string HttpDownload(string url, string localPath)
        {
            var name = url.Substring(url.LastIndexOf("/") + 1);

            using (var res = Connect(url, WebRequestMethods.Http.Get))
            {
                using (var stream = res.GetResponseStream())
                {
                    using (var fs = File.Create(Path.Combine(localPath, name)))
                    {
                        stream.CopyTo(fs);
                    }
                }
            }
            return name;
        }
    }
}
