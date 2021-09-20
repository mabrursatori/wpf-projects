using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Auth_BLL_Test.Auth_Folder
{
    class JsonTest
    {
       public static void requestJson()
        {
            var HttpWebRequest = (HttpWebRequest)WebRequest.Create("URL nya Di sini");
            HttpWebRequest.ContentType = "App/Json nya di sini";
            HttpWebRequest.Method = "Post";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            //using (var streamWriter = new StreamWriter(HttpWebRequest.GetRequestStream()))
            //{
            //    string json = new Java().Serialize(new
            //    {
            //        Username = "myusername",
            //        Password = "pass"
            //    });
            //    streamWriter.Write(json);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}

            var httpResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        
       public static bool GetJSON(string message)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("URL JSON di sini");
            httpWebRequest.ContentType = "JSON nya di sini";
            httpWebRequest.Method = "Post";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "";

                streamWriter.Write(json);
                
            }


            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                return true;
            }
        }

        public static void DownloadJson()
        {
            string responseString = string.Empty;
            using (var webclient = new WebClient()) 
            {
                responseString = webclient.DownloadString("URL JSON DI sini");
            }
        }

        public static void ReceiveResponse()
        {
            
        }
    }
}
