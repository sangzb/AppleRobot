using System;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
namespace AppleRobot
{
    public static class HttpWeb
    {
        public static string GetHtml(string URL)
        {
            string text = "";
            return HttpWeb.GetHtml(URL, out text);
        }
        public static string GetServerFromURL(string URL)
        {
            string result = "";
            if (URL.Length > 3)
            {
                int num = URL.IndexOf("://");
                if (-1 == num)
                {
                    num = 0;
                }
                int num2 = URL.IndexOf("/", num + 3);
                result = URL.Substring(num + 3, num2 - num - 3);
            }
            return result;
        }
        public static string smethod_0(string url, string name)
        {
            string text = "";
            int num = -1;
            string text2 = name + "=";
            int num2 = url.IndexOf(text2);
            if (num2 > 0)
            {
                num2 += text2.Length;
                num = url.IndexOf('&', num2);
                if (num == -1)
                {
                    num = url.Length;
                }
            }
            if (num - num2 > 0)
            {
                text = url.Substring(num2, num - num2);
            }
            return text.Trim();
        }
        public static string GetDataByServerStr(string sContent, string sNeedName)
        {
            int num = 0;
            return HttpWeb.GetDataByServerStr(sContent, sNeedName, ref num);
        }
        public static string GetDataByServerStr(string sContent, string sNeedName, ref int iIndex)
        {
            string text = "";
            int num = -1;
            string text2 = "\"" + sNeedName + "\"";
            int num2 = sContent.IndexOf(text2, iIndex);
            if (num2 > 0)
            {
                num2 = sContent.IndexOf(':', num2 + text2.Length);
            }
            if (num2 > 0)
            {
                num = sContent.IndexOf(',', num2);
                if (num == -1)
                {
                    num = sContent.IndexOf('}', num2);
                }
            }
            if (num - num2 > 0)
            {
                text = sContent.Substring(num2 + 1, num - num2 - 1);
                iIndex = num + 1;
            }
            if (text.Length > 0)
            {
                text = text.Replace("\"", "");
                text = text.Replace(" ", "");
                text = text.Replace("\r", "");
                text = text.Replace("\n", "");
                text = text.Replace("}", "");
                text = text.Replace("]", "");
                text = text.Replace("[", "");
                text = text.Replace("[", "");
                text = text.Replace("\"", "");
                text = text.Replace("\"", "");
            }
            return text;
        }
        public static DataTable GetGroupInfoByAjaxInfo(string sContent, string[] sNeedNames)
        {
            DataTable dataTable = null;
            int num = 0;
            bool flag = true;
            if (sNeedNames != null)
            {
                dataTable = new DataTable();
                for (int i = 0; i < sNeedNames.Length; i++)
                {
                    string columnName = sNeedNames[i];
                    DataColumn dataColumn = new DataColumn();
                    dataColumn.DataType = Type.GetType("System.String");
                    dataColumn.ColumnName = columnName;
                    dataTable.Columns.Add(dataColumn);
                }
                while (flag)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int j = 0; j < sNeedNames.Length; j++)
                    {
                        string text = sNeedNames[j];
                        string dataByServerStr = HttpWeb.GetDataByServerStr(sContent, text, ref num);
                        if (dataByServerStr != null && dataByServerStr.Length > 0)
                        {
                            dataRow[text] = dataByServerStr;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            return dataTable;
        }
        public static string GetInInfoBYNeed(string sContent, string sNeedName, string sValue)
        {
            string result = "";
            string value = sNeedName + "=\"" + sValue + "\"";
            int num = sContent.IndexOf(value);
            if (num > -1)
            {
                int num2 = sContent.LastIndexOf('<', num);
                int num3 = sContent.IndexOf('>', num);
                if (num3 > num2)
                {
                    result = sContent.Substring(num2, num3 - num2 + 1);
                }
            }
            return result;
        }
        public static string GetDivInfoBYNeed(string sContent, string sDivClass)
        {
            string result = "";
            string value = "class=\"" + sDivClass + "\"";
            int num = sContent.IndexOf(value);
            if (num > -1)
            {
                int num2 = sContent.IndexOf('>', num) + 1;
                int num3 = sContent.IndexOf("</div>", num2);
                if (num3 > num2)
                {
                    result = sContent.Substring(num2, num3 - num2);
                }
            }
            return result;
        }
        public static string GetNeedStrByIdName(string sContent, string sID, string sName, string sNeedName)
        {
            string result = "";
            string text = "";
            string inInfoBYNeed = HttpWeb.GetInInfoBYNeed(sContent, "id", sID);
            if (inInfoBYNeed.Length > 0)
            {
                text = HttpWeb.GetInInfoBYNeed(inInfoBYNeed, "name", sName);
            }
            if (text.Length > 0)
            {
                int num = text.IndexOf(sNeedName);
                if (num > -1)
                {
                    num = text.IndexOf('=', num);
                }
                if (num > -1)
                {
                    num = text.IndexOf('"', num);
                }
                if (num > -1)
                {
                    int num2 = text.IndexOf('"', num + 1);
                    result = text.Substring(num + 1, num2 - num - 1);
                }
            }
            return result;
        }
        public static int findSomethingInHtml(string strFind, string URL, out string strHtml)
        {
            string html = HttpWeb.GetHtml(URL);
            int result = html.IndexOf(strFind);
            strHtml = html;
            return result;
        }
        public static string GetHtml(string URL, out string cookie)
        {
            WebHeaderCollection webHeaderCollection = null;
            return HttpWeb.GetHtml(URL, out cookie, ref webHeaderCollection);
        }
        public static string GetHtml(string URL, out string cookie, ref WebHeaderCollection sHeaders)
        {
            CookieContainer cookieContainer = null;
            string text = null;
            return HttpWeb.GetHtml(URL, out cookie, ref cookieContainer, ref sHeaders, out text);
        }
        public static string GetHtml(string URL, out string cookie, ref CookieContainer cCon, ref WebHeaderCollection sHeaders, out string lasturl)
        {
            string result = "";
            string text = "";
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                httpWebRequest.AllowAutoRedirect = false;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Accept = " */*";
                httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
                if (cCon == null)
                {
                    CookieContainer cookieContainer = new CookieContainer();
                    httpWebRequest.CookieContainer = cookieContainer;
                    cCon = cookieContainer;
                }
                else
                {
                    httpWebRequest.CookieContainer = cCon;
                }
                httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                lasturl = URL;
                WebResponse response = httpWebRequest.GetResponse();
                if (response != null)
                {
                    text = response.Headers.Get("Location");
                }
                if (text != null && text.Length > 0)
                {
                    result = HttpWeb.GetHtml(text, out cookie, ref cCon, ref sHeaders, out lasturl);
                    httpWebRequest.GetResponse().Close();
                }
                else
                {
                    result = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();
                    httpWebRequest.GetResponse().Close();
                    cookie = response.Headers.Get("Set-Cookie");
                    sHeaders = response.Headers;
                    cCon = httpWebRequest.CookieContainer;
                }
            }
            catch (WebException ex)
            {
                result = "";
                cookie = "";
                lasturl = URL;
                throw ex;
            }
            catch (Exception)
            {
                result = "";
                cookie = "";
                lasturl = URL;
            }
            return result;
        }
        public static string PostHtml(string URL, string postData, string cookie, out string header, string server)
        {
            return HttpWeb.PostHtml(server, URL, postData, cookie, out header);
        }
        public static string PostHtml(string server, string URL, string postData, string cookie, out string header)
        {
            byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(postData);
            return HttpWeb.PostHtml(server, URL, bytes, cookie, out header);
        }
        public static string PostHtml(string server, string URL, byte[] byteRequest, string cookie, out string header)
        {
            byte[] buffer = HttpWeb.PostHtmlByBytes(server, URL, byteRequest, cookie, out header);
            Stream stream = new MemoryStream(buffer);
            StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
            string result = streamReader.ReadToEnd();
            streamReader.Close();
            stream.Close();
            return result;
        }
        public static string smethod_1(string str)
        {
            return HttpUtility.UrlEncode(str);
        }
        public static byte[] PostHtmlByBytes(string server, string URL, byte[] byteRequest, string cookie, out string header)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.SetCookies(new Uri(server), cookie);
            httpWebRequest.CookieContainer = cookieContainer;
            httpWebRequest.ContentType = "application/x-www-form-urlencoded";
            httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
            httpWebRequest.Referer = server;
            httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
            httpWebRequest.Method = "Post";
            httpWebRequest.ContentLength = (long)byteRequest.Length;
            Stream requestStream = httpWebRequest.GetRequestStream();
            requestStream.Write(byteRequest, 0, byteRequest.Length);
            requestStream.Close();
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            header = httpWebResponse.Headers.ToString();
            Stream responseStream = httpWebResponse.GetResponseStream();
            long contentLength = httpWebResponse.ContentLength;
            byte[] result = new byte[contentLength];
            result = HttpWeb.ReadFully(responseStream);
            responseStream.Close();
            return result;
        }
        public static byte[] ReadFully(Stream stream)
        {
            byte[] array = new byte[128];
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                while (true)
                {
                    int num = stream.Read(array, 0, array.Length);
                    if (num <= 0)
                    {
                        break;
                    }
                    memoryStream.Write(array, 0, num);
                }
                result = memoryStream.ToArray();
            }
            return result;
        }
        public static string GetHtml(string URL, string cookie, out string header, string server, out string lastUrl)
        {
            return HttpWeb.GetHtml(URL, cookie, out header, server, "", out lastUrl);
        }
        public static string GetRadomJsessionID()
        {
            string text = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            string text2 = string.Empty;
            for (int i = 0; i < 32; i++)
            {
                int startIndex = random.Next(0, text.Length);
                string str = text.Substring(startIndex, 1);
                text2 += str;
            }
            return text2;
        }
        public static string GetHtml(string URL, string cookie, out string header, string server, string val, out string lastUrl)
        {
            CookieContainer cookieContainer = null;
            byte[] bDataSend = new byte[0];
            return HttpWeb.GetHtml(URL, cookie, ref cookieContainer, out header, server, val, bDataSend, out lastUrl);
        }
        public static string GetHtml(string URL, string cookie, ref CookieContainer cCon, out string header, string server, string sendData, out string lastUrl)
        {
            byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(sendData);
            return HttpWeb.GetHtml(URL, cookie, ref cCon, out header, server, "", bytes, out lastUrl);
        }
        public static string PostHtml(string URL, string cookie, ref CookieContainer cCon, out string header, string ReferUrl, string sendData, out string lastUrl)
        {
            byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(sendData);
            string result = "";
            Stream stream = HttpWeb.GetStream(URL, cookie, ref cCon, out header, ReferUrl, "", bytes, 1, out lastUrl);
            if (stream != null)
            {
                StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                result = streamReader.ReadToEnd();
                streamReader.Close();
                stream.Close();
            }
            return result;
        }
        public static Stream GetStream(string URL, string cookie, ref CookieContainer cCon, out string header, string ReferUrl, string val, byte[] bDataSend, int iType, out string lasturl)
        {
            Stream result = null;
            string text = "";
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
                httpWebRequest.Accept = "*/*";
                httpWebRequest.Referer = ReferUrl;
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Maxthon; .NET CLR 1.1.4322)";
                if (cCon == null)
                {
                    CookieContainer cookieContainer = new CookieContainer();
                    cookieContainer.SetCookies(new Uri(ReferUrl), cookie);
                    httpWebRequest.CookieContainer = cookieContainer;
                    cCon = cookieContainer;
                }
                else
                {
                    httpWebRequest.CookieContainer = cCon;
                }
                if (iType == 1)
                {
                    httpWebRequest.Method = "POST";
                    if (bDataSend.Length > 0)
                    {
                        httpWebRequest.ContentLength = (long)bDataSend.Length;
                        Stream requestStream = httpWebRequest.GetRequestStream();
                        requestStream.Write(bDataSend, 0, bDataSend.Length);
                        requestStream.Close();
                    }
                }
                else
                {
                    httpWebRequest.Method = "GET";
                }
                httpWebRequest.AllowAutoRedirect = false;
                lasturl = URL;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (httpWebResponse != null)
                {
                    text = httpWebResponse.Headers.Get("Location");
                }
                if (text != null && text.Length > 0)
                {
                    result = HttpWeb.GetStream(text, cookie, ref cCon, out header, ReferUrl, val, null, 0, out lasturl);
                }
                else
                {
                    header = httpWebResponse.Headers.ToString();
                    result = httpWebResponse.GetResponseStream();
                }
            }
            catch (WebException ex)
            {
                header = null;
                lasturl = URL;
                throw ex;
            }
            catch (Exception)
            {
                header = null;
                lasturl = URL;
            }
            return result;
        }
        public static string GetHtml(string URL, string cookie, ref CookieContainer cCon, out string header, string server, string val, byte[] bDataSend, out string lastUrl)
        {
            string result = "";
            Stream stream = HttpWeb.GetStream(URL, cookie, ref cCon, out header, server, val, bDataSend, 0, out lastUrl);
            if (stream != null)
            {
                StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                result = streamReader.ReadToEnd();
                streamReader.Close();
                stream.Close();
            }
            return result;
        }
        public static Stream GetStreamByBytes(string server, string URL, string cookie)
        {
            return HttpWeb.GetCode(server, URL, cookie);
        }
        public static Stream GetCode(string server, string url, string cookie)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            CookieContainer cookieContainer = new CookieContainer();
            cookieContainer.SetCookies(new Uri(server), cookie);
            httpWebRequest.CookieContainer = cookieContainer;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            return httpWebResponse.GetResponseStream();
        }
        public static string GetUser(string server, string url, string cookie)
        {
            string result = "";
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                CookieContainer cookieContainer = new CookieContainer();
                cookieContainer.SetCookies(new Uri(server), cookie);
                httpWebRequest.CookieContainer = cookieContainer;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                result = streamReader.ReadToEnd();
                try
                {
                    httpWebRequest.GetResponse().Close();
                }
                catch (WebException ex)
                {
                    throw ex;
                }
                streamReader.Close();
                responseStream.Close();
            }
            catch
            {
            }
            return result;
        }
        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
        public static bool CheckHttps(HttpWebRequest webrequest)
        {
            try
            {
                if (webrequest.RequestUri.Scheme == "https")
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(HttpWeb.CheckValidationResult);
                    X509Store x509Store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                    x509Store.Open(OpenFlags.ReadWrite);
                    string hostName = Dns.GetHostName();
                    X509Certificate2Collection x509Certificate2Collection = x509Store.Certificates.Find(X509FindType.FindByIssuerName, hostName, false);
                    Console.WriteLine(x509Certificate2Collection.Count);
                    if (x509Certificate2Collection.Count <= 0)
                    {
                        throw new Exception("无效的证书，请确保证书存在且有效！");
                    }
                    X509Certificate2 value = x509Certificate2Collection[0];
                    webrequest.ClientCertificates.Add(value);
                }
            }
            catch (WebException ex)
            {
                throw new WebException(ex.Message, ex.InnerException);
            }
            catch (Exception ex2)
            {
                throw new Exception(ex2.Message, ex2.InnerException);
            }
            return true;
        }
    }
}
