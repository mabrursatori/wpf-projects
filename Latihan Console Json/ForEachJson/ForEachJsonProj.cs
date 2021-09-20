using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ForEachJson
{
    class ForEachJsonProj
    {
        public class Response
        {
            public string auth_type { get; set; }
            
            public string staff_id { get; set; }
            public string staff_pin { get; set; }
        }

        public partial class Process 
        {
            public void HTTP(string httpreq) 
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.8.40:30003/authwsdl/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    string json = "{\"auth_type\":\"7\"," + 
                        "\"staff_id\":\"1234567890\"," 
                        + "\"staff_pin\":\"1234\"}";

                    dynamic json2 = JsonConvert.DeserializeObject<JObject>(json);
                    

                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();


                    Console.WriteLine(result);
                }

            }
        }
        static void Main(string[] args) 
        {
            #region test01
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.8.40:30003/authwsdl/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string text = "";
                string json = "{\"auth_type\":\"7\"," +
                    "\"staff_id\":\"1234567890\","
                    + "\"staff_pin\":\"1234\"}";

                dynamic json2 = JsonConvert.DeserializeObject<JObject>(json);


                streamWriter.Write(json);
                text = Console.WriteLine(json2.staff_id);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();


                Console.WriteLine(result);
            }
            #endregion



            string readstring = "{\"auth_type\":\"5\"," + "\"account_type\":\"1\"," +
                    "\"card_id\":\"1234567890\"," + "\"card_pin\":\"1234\"}";
            Response response = JsonConvert.DeserializeObject<Response>(readstring);
            Console.WriteLine(response.staff_id);

            Console.Read();
        }
    }
}
