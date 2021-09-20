using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

namespace SerializeDeseJSON
{
    class Program
    {
        #region Response

        public class Response
        {
            public int ID { get; set; }

            public string Status { get; set; }
            
        }

        public class Response2 
        { 
            public int ID { get; set; }

            public string Status { get; set; }

            [JsonPropertyName("Wind")]
            public int Windspeed { get; set; }
        }

        public class properties
        {
            public string userId { get; set; }

            public string propertyName { get; set; }

            public string propertyDesc { get; set; }
        }

        public class InfoCust
        {
            public string machine_name { get; set; }
            public int sequence_no { get; set; }

            [JsonPropertyName("details")]
            public string currency { get; set; }
            public int count { get; set; }

            public int denom { get; set; }

        }

        #endregion

        #region class
        // Class TJson sudah OK, copy sebelum di ubah
        public partial class TJson 
        {
            public bool APIjson (string userPropertiesAsJsonString, string URL,out string propertyName )
            {
                bool successtest = false;
                string responsefromserver = "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "POST";
                byte[] byteArray = Encoding.UTF8.GetBytes(userPropertiesAsJsonString);// gzip
                request.ContentType = "application/json; charset=utf-8;";//diganti jadi ke json
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responsefromserver = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                dynamic json = JsonConvert.DeserializeObject(responsefromserver);
                propertyName = json.json.properties.propertyDesc;

                return successtest;
            }
        }

        public partial class ResponseJson
        {
            public bool APIjson2(string InfoCust, string rURL, out string CstName)
            {
                bool successtest = false;
                string responsefromserver = "";
                

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(rURL);
                request.Method = "POST";
                byte[] byteArray = Encoding.UTF8.GetBytes(InfoCust);// gzip
                request.ContentType = "application/json; charset=utf-8;";//diganti jadi ke json
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responsefromserver = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                dynamic json = JsonConvert.DeserializeObject<dynamic>(responsefromserver);

                //CstName = ((JObject)json?.CstName).ToObject<InfoCust>().ToString() ;
                //CstName = json.json.details[1].ToString();
                CstName = json.json.details.ToString();

                return successtest;
            }

        }


        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Response BNI = new Response { ID = 1, Status = "OK"};
            string result = JsonConvert.SerializeObject(BNI);
            Console.WriteLine(result);

            #region test Deserialization
            //string JsonResult = @"[{'ID' : '1','Status':'OK','Windspeed' :'35'}]";
            //var result2 = JsonConvert.DeserializeObject<List<Response2>>(JsonResult);
            //Console.WriteLine(result2);
            //Console.Read();
            #endregion

            #region Test Kemarin
            //string Post = "{\"ID\":1,\"Status\":\"OK\"}";
            //string sURL = "http://httpbin.org/post";
            //string Sstatus = string.Empty;

            //TJson testjson = new TJson();
            //testjson.APIjson(Post, sURL, out string sStatus);
            #endregion

            #region Call JSON stringify 

            string userPropertiesAsJsonString = "{\"properties\":{\"propertyName\":\"test\",\"propertyDesc\":\"desc\"}}";
            string sURL = "http://httpbin.org/post";
            string propertyName = string.Empty;

            TJson testjson = new TJson();
            testjson.APIjson(userPropertiesAsJsonString, sURL, out propertyName);

            Console.WriteLine(propertyName);
            #endregion // sudah OK

            #region Call kurawal ke bracket menuju console
            
            string InfoCust = "{\"cst_name\":\"CST0\",\"verify_bit\":0,\"sensor_full\":0,\"details\":[{\"currency\":\"IDR\"," +
                "\"count\":50,\"denom\":1000},{\"currency\":\"IDR\",\"count\":40,\"denom\":2000},{\"currency\":\"IDR\",\"count\":30,\"denom\":5000}," +
                "{\"currency\":\"IDR\",\"count\":20,\"denom\":10000}]}";
            


            string rURL = "http://httpbin.org/post";
            string CstName = string.Empty;

            ResponseJson response = new ResponseJson();
            response.APIjson2(InfoCust,rURL,out CstName);

            Console.WriteLine(CstName);

            #endregion

            Console.Read();
        }
    }
}
