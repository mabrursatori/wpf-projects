using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;

namespace PostJsonTrain02
{
    public class Training
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

            public bool Result(string json, string URL,out string status)
            {
                bool resultresponse = false;
                var request = (HttpWebRequest)WebRequest.Create(URL);
                request.ContentType = "application/json";
                request.Method = "POST";

                var writer = new StreamWriter(request.GetRequestStream());
                string wrote = json;
                writer.Write(wrote);

                var httpResponse = (HttpWebResponse)request.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();

                dynamic R = JsonConvert.DeserializeObject<dynamic>(wrote);
                status = R.auth_type;

                return resultresponse;
            }
        }
        static void Main(string[] args) 
        {
            string json = "{\"auth_type\":\"7\"," +
                       "\"staff_id\":\"1234567890\","
                       + "\"staff_pin\":\"1234\"}";
            string URL = "http://192.168.8.40:30003/authwsdl/";
            string status = string.Empty;

            ResponseJSON responseJSON = new ResponseJSON();
            responseJSON.Result(json,URL,out status);

            Console.WriteLine(status);
            //Console.WriteLine(status);
            //Console.Read();
        }
    }
}
