using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Net.Http;

namespace JsonObject
{
    class JsonObject
    {
        public class Kondisi
        {
            public string status { get; set; }
            public string name { get; set; }
            public string positition { get; set; }
            public int no_id { get; set; }
            public string time_auth { get; set; }
            public string account_type { get; set; }
            public string accout_type_detail { get; set; }
            public string auth_type { get; set; }
            public string staff_id { get; set; }
            public string staff_pin { get; set; }

        }

        public partial class ResponseJSON
        {
            public bool Result(string jsonData, string URL, out string status)
            {
                bool resultresponse = false;
                var request = (HttpWebRequest)WebRequest.Create(URL);
                request.ContentType = "application/json";
                request.Method = "POST";

                var writer = new StreamWriter(request.GetRequestStream());
                string wrote = jsonData;
                writer.Write(wrote);

                var httpResponse = (HttpWebResponse)request.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();

                dynamic R = JsonConvert.DeserializeObject<dynamic>(wrote);
                status = R.auth_type;

                return resultresponse;
            }

            
        }


        static async Task Main(string[] args)
        {
            string jsonData = @"{  
            'auth_type':'7',  
            'staff_id':'1234567890',
            'staff_pin': '1234'}";
            dynamic data = JObject.Parse(jsonData);
            string URL = "http://192.168.8.40:30003/authwsdl/";
            string status = string.Empty;

            ResponseJSON responseJSON = new ResponseJSON();
            responseJSON.Result(jsonData, URL, out status);

            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = await client.GetAsync("http://192.168.8.40:30003/authwsdl/");
            //response.EnsureSuccessStatusCode();
            //string responseBody = await response.Content.ReadAsStringAsync();


            Console.WriteLine(status);
            
            Console.Read();

        }
    }
}
