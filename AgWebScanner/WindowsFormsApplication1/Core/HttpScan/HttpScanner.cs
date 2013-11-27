using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using HtmlAgilityPack;
using System.Net.Sockets;
//using AgWebScanner.Controls;
using System.Web;
using System.Drawing;

namespace AgWebScanner.Core.HttpScan
{
    public class SParams
    {
        public int test_mode;
        public string base_url;

        public string get_uri;
        public string post_uri;
        public string post_data;
        public string options_uri;
        public string delete_uri;
        public string head_uri;
        public string put_uri;
        public string put_path;
        public string wrongmethod_met;
        public string wrongversion_ver;
        public string trace_uri;
        public string connect_uri;
        public string propfind_uri;

        public string[] test_names;

        public SParams()
        {
            test_names = new string[40];
        }

    }

    public struct SResult
    {
        public string name;
        public string request;
        public string response;
        public string status;

        public string full_request;
        public string full_response;
    }

    internal class HttpScanner : IDisposable
    {
        #region Fields
        private static string _baseUrl;
        private static volatile bool _terminate;
        private List<Thread> _threads;
        //public static List<ResponseDetails> ResponseDetails { get; set; }
        private static int cur_cursor;
        private static Command a1;
        private static string buffer;
        private static BackgroundWorker bgWorker;
        public static SResult[] results = new SResult[30];
        #endregion Fields

        #region Constructors

        public HttpScanner()
        {
            //_baseUrl = baseUrl;
            cur_cursor = 0;
            a1 = new Command();
            a1.AddToConsole = true;

            buffer = "";
        }

        #endregion Constructors

        #region Methods

        public void Dispose()
        {
            if (this._threads != null)
            {
                _terminate = true;
                foreach (var t in this._threads)
                {
                    t.Interrupt();
                }

                //ResponseDetails = null;
            }
        }

        private void WaitForCompletedThreads()
        {
            foreach (var t in this._threads)
            {
                t.Join();
            }
        }

        #region https_hack

		public static void AllowInvalidCertificate()
		{
			//ServicePointManager.ServerCertificateValidationCallback += allowCert;
            ServicePointManager.ServerCertificateValidationCallback = allowCert;
		}

		private static bool allowCert( object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error )
		{
			return true;
		}

		#endregion https_hack

        #endregion Methods

        public void ConsoleSetSection(int section)
        {
            // 0 == name   1==request

            int blength = 0;
            if (section >= 1)
                blength += 22;
            if (section >= 2)
                blength += 32;
            if (section >= 3)
                blength += 22;

            for (int i = cur_cursor; i < blength; i++)
            {
                buffer += " ";
                cur_cursor++;
            }
        }

        public void ConsoleAppend(string af)
        {
            buffer += af;
            cur_cursor += af.Length;
        }

        public void ConsoleFlush(System.Drawing.Color color)
        {
            a1.AddToConsoleStr.Add(buffer);
            a1.AddToConsoleColor.Add(color);
            bgWorker.ReportProgress(1, a1);
            buffer = "";
            //cur_cursor = 0;
        }

        public void ConsoleNewline(System.Drawing.Color color)
        {
            buffer += "\r\n";
            cur_cursor++;
            ConsoleFlush(color);
            cur_cursor = 0;
            buffer = "";
        }

        public void ConsoleSeparator(System.Drawing.Color color)
        {
            ConsoleNewline(color);
            ConsoleAppend("----------------------------------------------------------------------------------------");
            ConsoleNewline(color);
        }

        public void Scan(BackgroundWorker _bgWorker, SParams parm)
        {
            bgWorker = _bgWorker;

            cur_cursor = 0;
            buffer = "";

            ConsoleSetSection(3);
            ConsoleAppend("Scan started");
            ConsoleFlush(Color.Blue);

            // TCPCLIENT!! dla reszty testów
            

            string url = parm.base_url;

            int from = parm.test_mode;
            int to = parm.test_mode;

            if (parm.test_mode == 18) // select all
            {
                from = 3;
                to = 18;
            }

            for (int i = from; i <= to; i++) // tests
            {
                if (i == 18) // 'select all' test
                    continue;

                results[i].full_response = "";
                results[i].full_request = "";
                results[i].response = "";
                results[i].request = "";

                url = parm.base_url;

                ConsoleSeparator(Color.Black);
                ConsoleAppend(parm.test_names[i - 3]);
                //ConsoleSetSection(1);
                ConsoleFlush(Color.Black);

                results[i].name = parm.test_names[i - 3];

                // USING WEBREQUEST
                // POST, GET, HEAD, wrongmethod, OPTIONS, TRACE, PUT
                //if (  (i == 13) )
                if(false) /// CAN DELETE THIS
                {
                    if ((i == 13) && (parm.put_uri != ""))
                        url = parm.put_uri;

                    if (url.Contains("https"))
                    {
                        AllowInvalidCertificate();
                    }

                    var request = (HttpWebRequest)WebRequest.Create(url);
                   
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0";
                    request.Headers.Add("Accept-Language", "en-US");
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                    if (i == 7)
                        request.Method = WebRequestMethods.Http.Get;
                    else if (i == 6)
                    {
                        request.Method = WebRequestMethods.Http.Post;
                        request.ContentType = "application/x-www-form-urlencoded";
                    }
                    else if (i == 14)
                        request.Method = WebRequestMethods.Http.Head;
                    else if (i == 11)
                        request.Method = "OPTIONS";
                    else if (i == 16)
                        request.Method = parm.wrongmethod_met;
                    else if (i == 9)
                        request.Method = "TRACE";
                    else if (i == 13)
                    {
                        request.Method = WebRequestMethods.Http.Put;
                        request.ContentType = "application/octet-stream";
                    }
 
                   // request.Method = WebRequestMethods.Http.Put
                    //request.Method = WebRequestMethods.Http.Connect
                    
                    request.KeepAlive = false;
                    request.Proxy = null;
                    request.Credentials = CredentialCache.DefaultCredentials;

                    if (i == 6) // post data
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(parm.post_data);
                        request.ContentLength = bytes.Length;

                        Stream stream = request.GetRequestStream();
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Close();
                    }

                    if (i == 13) // put data
                    {
                        if (parm.put_path == "")
                        {
                            request.ContentLength = 0;
                        }
                        else
                        {
                            FileStream ReadIn = new FileStream(parm.put_path, FileMode.Open, FileAccess.Read);
                            ReadIn.Seek(0, SeekOrigin.Begin);
                            request.ContentLength = ReadIn.Length;
                            Byte[] FileData = new Byte[ReadIn.Length];
                            int DataRead = 0;
                            Stream tempStream = request.GetRequestStream();
                            do
                            {
                                DataRead = ReadIn.Read(FileData, 0, (Math.Min(2048, (int)ReadIn.Length)));
                                if (DataRead > 0)
                                {
                                    tempStream.Write(FileData, 0, DataRead);
                                    Array.Clear(FileData, 0, DataRead);
                                }
                            } while (DataRead > 0);

                            ReadIn.Close();
                            tempStream.Close();
                        }
                    }

                    HttpStatusCode status = 0;
                    HttpWebResponse response = null;

                    string send4 = request.Method + " ";

                    if(url.Substring(0,7) == "http://")
                        url = url.Substring(7,url.Length-7);
                    else if(url.Substring(0,8) == "https://")
                        url = url.Substring(8, url.Length-8);

                    int c = url.Length;
                    for (int b = 0; b < url.Length; b++)
                        if (url[b] == '/')
                        {
                            c = b;
                            break;
                        }
                    if (c == url.Length)
                        url = "/";
                    else
                        url = url.Substring(c, url.Length-c);
                    
                    //HttpUtility.UrlEncode(url)
                    send4 += HttpUtility.UrlPathEncode(url) + " HTTP/1.1";

                    ConsoleSetSection(1);
                    ConsoleAppend(send4);
                    ConsoleFlush(Color.SlateGray);

                    results[i].request = send4;

                    results[i].full_request = "";

                    try
                    {
                        response = (HttpWebResponse)request.GetResponse();

                        status = response.StatusCode;

                        Stream receiveStream = response.GetResponseStream();
                       // Encoding encode = System.Text.Encoding. GetEncoding("utf-8");
                        // Pipes the stream to a higher level stream reader with the required encoding format. 
                        StreamReader readStream = new StreamReader(receiveStream);

                        results[i].full_response = readStream.ReadToEnd();
                        readStream.Close();

                        response.Close();
                    }
                    catch (WebException e)
                    {
                        if (e.Status == WebExceptionStatus.ProtocolError)
                        {
                            status = ((HttpWebResponse)e.Response).StatusCode;
                        }
                        //else
                        // e.Status.ToString();
                    }

                    int mt = ((int)status) / 100;

                    ConsoleSetSection(2);
                    ConsoleAppend(((int)status).ToString() + " " + status.ToString());

                    results[i].response = ((int)status).ToString() + " " + status.ToString();

                    if (mt == 2)
                        ConsoleFlush(Color.Green);
                    else if (mt == 4)
                        ConsoleFlush(Color.Red);
                    else if (mt == 5)
                        ConsoleFlush(Color.Red);
                    else
                        ConsoleFlush(Color.Black);
                }

                // USING TCPCLIENT
                // Fake End in URI, URI encoding, URI backslashes, Header multiple lines, HTTP wrong version,
                // CONNECT, PROPFIND, DELETE, POST, GET, OPTIONS
               // if ((i == 3) || (i == 4) || (i == 5) || (i == 6) || (i == 7) || (i == 8) || (i == 9)
                //    || (i == 11) || (i == 12) || (i == 14) || (i == 15) || (i==16) ||  (i == 17) || (i == 10))

                if(true)
                {
                    if ((i == 6) && (parm.post_uri != ""))
                        url = parm.post_uri;
                    else if ((i == 17) && (parm.propfind_uri != ""))
                        url = parm.propfind_uri;
                    else if ((i == 10) && (parm.delete_uri != ""))
                        url = parm.delete_uri;
                    else if ((i == 12) && (parm.connect_uri != ""))
                        url = parm.connect_uri;
                    else if ((i == 7) && (parm.get_uri != ""))
                        url = parm.get_uri;
                    else if ((i == 11) && (parm.options_uri != ""))
                        url = parm.options_uri;
                    else if ((i == 9) && (parm.trace_uri != ""))
                        url = parm.trace_uri;
                    else if ((i == 14) && (parm.head_uri != ""))
                        url = parm.head_uri;
                    else if ((i == 13) && (parm.put_uri != ""))
                        url = parm.put_uri;

                    bool is_https = false;
                    int port = 80;
                    if (url.Substring(0, 7) == "http://")
                        url = url.Substring(7, url.Length - 7);
                    else if (url.Substring(0, 8) == "https://")
                    {
                        url = url.Substring(8, url.Length - 8);
                        is_https = true;
                        port = 443;
                        AllowInvalidCertificate();
                    }

                    int c = url.Length;
                    for (int b = 0; b < url.Length; b++)
                        if (url[b] == '/')
                        {
                            c = b;
                            break;
                        }

                    string url2;
                    if (c == url.Length)
                        url2 = "/";
                    else
                        url2 = url.Substring(c, url.Length - c);
                    // /index.html

                    url = url.Substring(0, c); // www.site.com

                    

                    //method
                    string send = "";

                    if (i == 12)
                        send += "CONNECT ";
                    else if (i == 17)
                        send += "PROPFIND ";
                    else if (i == 10)
                        send += "DELETE ";
                    else if (i == 6)
                        send += "POST ";
                    else if (i == 11)
                        send += "OPTIONS ";
                    else if (i == 9)
                        send += "TRACE ";
                    else if (i == 14)
                        send += "HEAD ";
                    else if (i == 16)
                        send += parm.wrongmethod_met + " ";
                    else if (i == 13)
                        send += "PUT ";
                    else
                        send += "GET ";

                    //URI
                    if (i == 3)
                        send += "/%20HTTP/1.1/../../ ";
                    else if (i == 4)
                        send += "/%2F ";// ??????????????????????
                    else if (i == 5)
                        send += "\\ ";
                    else if (i == 8)
                        send += "/ ";
                    else if (i == 15)
                        send += "/ ";
                    else if (i == 12)
                        send += url + " ";
                    else
                        send += url2 + " ";

                    //version
                    if (i == 15)
                        send += "HTTP/"+parm.wrongversion_ver;
                    else if(i==5)
                        send += "HTTP\\1.1";
                    else
                        send += "HTTP/1.1";

                    ConsoleSetSection(1);
                    ConsoleAppend(send);
                    ConsoleFlush(Color.SlateGray);

                    results[i].request = send;

                    //newline
                    send += "\r\n";
                    if(i==8)
                        send += "\r\n";

                    //

                    send += "Host: " + url + "\r\n";
                    send += "User-Agent: Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0\r\n";
                    send += "Accept-Language: en-US\r\n";
                    send += "Accept: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8\r\n";

                    if (i == 6)
                    {
                        send += "Content-Type: application/x-www-form-urlencoded\r\n";
                        send += "Content-Length: " + System.Web.HttpUtility.UrlEncode(parm.post_data).Length.ToString()+"\r\n";
                        //send += "Expect: 100-continue\r\n";
                    }

                    Byte[] FileData = null;
                    long ContentLength = 0;

                    if( i == 13)
                    {
                        if (parm.put_path != "")
                        {
                            FileStream ReadIn = new FileStream(parm.put_path, FileMode.Open, FileAccess.Read);
                            ReadIn.Seek(0, SeekOrigin.Begin);
                            ContentLength = ReadIn.Length;
                            FileData = new Byte[ReadIn.Length];
                            int DataRead = 0;
                            int offset = 0;

                            int numBytesToRead = (int)ReadIn.Length;
                            int numBytesRead = 0;
                            while (numBytesToRead > 0)
                            {
                                int n = ReadIn.Read(FileData, numBytesRead, numBytesToRead);

                                if (n == 0)
                                    break;

                                numBytesRead += n;
                                numBytesToRead -= n;
                            }
                            numBytesToRead = (int)ReadIn.Length;

                            ReadIn.Close();
                        }
                        else
                            ContentLength = 0;

                        send += "Content-Type: application/octet-stream\r\n";
                        send += "Content-Length: " + ContentLength.ToString() + "\r\n";
                    }

                    send += "Connection: Close\r\n";
                    send += "\r\n";

                    if (i == 6)
                        send += System.Web.HttpUtility.UrlEncode(parm.post_data);
                   // if (i == 13)
                       // send += System.Text.Encoding.ASCII.GetString(FileData,0,(int)ContentLength);
                        //send += System.Text.Encoding.UTF8.GetString(FileData, 0, (int)ContentLength);
                       // send += BitConverter.ToString(FileData);
                    //BitConverter.

                    //results[i].full_request = send;

                    TcpClient tcp = new TcpClient(url, port);
                    tcp.SendTimeout = 8000;
                    tcp.ReceiveTimeout = 8000;

                    StreamReader reader;
                    StreamWriter writer;
                    //SslStream gga= null;

                    SslStream sstre = null;
                    NetworkStream nets = null;

                    if(is_https)
                    {
                        sstre = new System.Net.Security.SslStream(tcp.GetStream(), true, allowCert, null);
                        sstre.AuthenticateAsClient(url);
                        
                        reader = new StreamReader(sstre);
                        //writer = new StreamWriter(sstre);
                        //gga = sstre;
                    }
                    else
                    {
                        nets = tcp.GetStream();
                        reader = new StreamReader(tcp.GetStream());
                        //writer = new StreamWriter(tcp.GetStream());
                    }

                    string respon = "";

                    byte[] sbyt = System.Text.Encoding.ASCII.GetBytes(send);

                    int siz = sbyt.Length+(int)ContentLength;
                    byte[] full = new byte[siz];
                    sbyt.CopyTo(full,0);
                    if(FileData!=null)
                        FileData.CopyTo(full,sbyt.Length);

                    results[i].full_request = System.Text.Encoding.ASCII.GetString(full, 0, siz);

                    try
                    {
                        if (is_https)
                        {
                            sstre.Write(full, 0, siz);
                            sstre.Flush();
                        }
                        else
                        {
                            nets.Write(full, 0, siz);
                            nets.Flush();
                        }
                        // writer.Write(send);

                        //writer.Flush();
                    }
                    catch (System.Net.Sockets.SocketException e)
                    {
                        respon = "ERROR";
                    }
                    catch (System.IO.IOException e2)
                    {
                        respon = "ERROR";
                    }

                    //char[] rbuff = null;
                    //rbuff = new char[2048];

                    

                    try
                    {
                        string agg = reader.ReadToEnd();
                        //reader.Read(rbuff,0,2047);

                        results[i].full_response = agg;

                        bool t4 = false;
                        int pos1 = 0;
                        int pos2 = 0;
                        for(int h=0;h<agg.Length;h++)
                        {
                            if(!t4)
                            {
                                if(agg[h]==' ')
                                {
                                    pos1=h+1;
                                    t4=true;
                                }
                            }
                            else
                            {
                                if((agg[h]=='\r')||(agg[h]=='\n'))
                                {
                                    pos2 = h;
                                    respon = agg.Substring(pos1,pos2-pos1);
                                    break;
                                }
                            }
                        }
                    }
                    catch (IOException e)
                    {
                        respon = "ERROR";
                    }

                    int mt = 4;
                    if((respon!="")&&(respon!="ERROR"))
                        mt = Convert.ToInt32(respon.Substring(0, 1));

                    //ConsoleSetSection(2);
                    //ConsoleAppend(((int)status).ToString() + " " + status.ToString());

                    ConsoleSetSection(2);
                    ConsoleAppend(respon);

                    results[i].response = respon;

                    if (mt == 2)
                        ConsoleFlush(Color.Green);
                    else if (mt == 4)
                        ConsoleFlush(Color.Red);
                    else if (mt == 5)
                        ConsoleFlush(Color.Red);
                    else
                        ConsoleFlush(Color.Black);
                }

                ConsoleSetSection(3);
                ConsoleAppend("Done.");
                //ConsoleNewline();
                ConsoleFlush(Color.Blue);

                if (bgWorker.CancellationPending == true)
                    break;
            }
            
            while (true)
            {
                if (a1.AddToConsoleStr.Count == 0)
                    break;

                Thread.Sleep(100);
            }
        }
    }
}