using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace CodemeFramework.includes
{
    class Http
    {

        public static string get(string url)
        {
            string result = "";

            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            //client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            result = reader.ReadToEnd();

            data.Close();
            reader.Close();

            return result;
        }

        public static string post(string URI, string Parameters,string proxyStr="")
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(URI);

            if (proxyStr.Length > 5)
            {
                req.Proxy = new System.Net.WebProxy(proxyStr, true);
            }
            //Add these, as we're doing a POST
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            //We need to count how many bytes we're sending. 
            //Post'ed Faked Forms should be name=value&
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Parameters);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length); //Push it out there
            os.Close();
            System.Net.WebResponse resp = req.GetResponse();
            if (resp == null) return null;
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }
}
