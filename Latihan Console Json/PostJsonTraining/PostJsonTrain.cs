using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PostJsonTraining
{
    class Program
    {
        public class Response 
        {
            public string auth_type { get; set; }
            public string account_type { get; set; }
            public string card_id { get; set; }

            public string card_pin { get; set; }
        }

        static void Main(string[] args)
        {

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.8.40:30003/authwsdl/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                
                string json = "{\"auth_type\":\"5\"," + "\"account_type\":\"1\"," + 
                    "\"card_id\":\"1234567890\","+ "\"card_pin\":\"1234\"}";

                dynamic json2 = JsonConvert.DeserializeObject<JObject>(json);
                string auth_type = (string)"auth_type";
                
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();


                Console.WriteLine(result);
            }

            
            Console.Read();
        }
    }
}
