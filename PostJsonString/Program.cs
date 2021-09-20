using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using System.Reflection;

namespace PostJsonString
{

    public class Res 
    {
        public string Auth { get; set; }

        public int CardID { get; set; }

        public string CardPin { get; set; }
    }

    public class Res2
    {
        public string Status { get; set; }

        public string Auth_ID { get; set; }
    }

    public partial class PIPassword {
        public bool APIIdPassword(string Post, string URL, out string sAuth)
        {
            //Request
            bool ISSuccess = false;
            string responsefromserver = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent =
                              "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 7.1; Trident/5.0)";
            request.Accept = "*/*";
            
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(Post);// gzip
            request.ContentType = "application/json; charset=utf-8;";//diganti jadi ke json
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            //Response
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            responsefromserver = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();


            dynamic json = JsonConvert.DeserializeObject(responsefromserver);
            sAuth = json.Auth;

            return ISSuccess;
        }

        
    }

    public partial class TJson
    {
        public bool APIJSONTEST(string Post, string URL, out string Auth)
        {
            bool successtest = false;
            string responsefromserver = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(Post);// gzip
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
            Auth = json.data.status;

            return successtest;
        }
    }

    

    class Program
    {

        public class Response
        {
            public string StatusCode { get; set; }
            public string Status { get; set; }

            [JsonExtensionData]
            public Dictionary<string, JToken> data;
        }

        #region
        static async Task Main(string[] args)
        {
            #region API Request
            //var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.8.40:30003");
            //httpWebRequest.ContentType = "application/json";
            //httpWebRequest.Method = "POST";

            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string json = "{\"user\":\"test\"," + "\"password\":\"bla\"}";


            //    streamWriter.Write(json);
            //}

            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}

            //=========================================

            //using var client = new HttpClient();
            //var content = await client.GetStringAsync("URL taruh di sini");

            //Console.WriteLine(content);

            //===============================================================

            #endregion

            #region HTTP POST Request
            //var person = new Person();
            //person.Name  = "John Doe";
            //person.Occup = "Warrior";

            //var json = JsonConvert.SerializeObject(person);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");

            //var url = "https://httpbin.org/post";
            //using var client = new HttpClient();

            //var response = await client.PostAsync(url, data);

            //string result = response.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(result);
            //Console.ReadLine();
            #endregion

            #region HTTP JSON Request

            //using var client = new HttpClient();

            //client.BaseAddress = new Uri("https://api.github.com");
            //client.DefaultRequestHeaders.Add("User-Agent", "c# Console Program");
            //client.DefaultRequestHeaders.Accept.Add(
            //        new MediaTypeWithQualityHeaderValue("application/json"));

            //var url = "repos/symfony/symfony/contributors";
            //HttpResponseMessage response = await client.GetAsync(url);
            //response.EnsureSuccessStatusCode();
            //var resp = await response.Content.ReadAsStringAsync();

            //List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(resp);
            //contributors.ForEach(Console.WriteLine);

            #endregion

            #region Testing APIJSON

            #region test1
            /*
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.8.40/authwsdl");
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Method = "POST";

                        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                        {
                            string json = "{\"auth_type\":\"5\"," + "\"card_id\":\"12345\"  "+"\"card_pin\":\"12321\" }";


                            streamWriter.Write(json);
                        }

                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var result = streamReader.ReadToEnd();
                        }

                        Console.ReadLine();
            */
            #endregion

            #region Test 2
            /*
            //string Post = "{\"auth_type\":\"5\"," + "\"card_id\":\"12345\"  " + "\"card_pin\":\"12321\" }";
            string Post = "{\r\n    \"Auth_type\" : 5,\r\n    \"Card_ID\" : 12345,\r\n    \"Card_Pin\" : 55555\r\n}";
            string sAuth = string.Empty;
            string card_pin = string.Empty;
            string sURL = "http://192.168.8.40:30003/authwsdl/";


            PIPassword AuIdPass = new PIPassword();
            AuIdPass.APIIdPassword(Post,sURL,out sAuth);
            */
            #endregion

            #region Test 3  Half Complete

            //string Post = "{\r\n    \"Status\" : \"Success\",\r\n    \"Auth_type\": 51,\r\n    \"Card_ID\": 12345,\r\n    \"Card_Pin\": 55555,\r\n    \"CardHolder\" : \"Deston\"\r\n}";

            string Post = "{\r\n    \"Status\" : \"Success\",\r\n    \"Auth_ID\" : 1,\r\n    \"ActiveDate\" : \"2020-11-09T04:42:36.489Z\",\r\n  " +
                "  \"Auth_Type\" : [\r\n        {\r\n            \"Auth_Name\" : \"Setoran\",\r\n            \"Auth_Pass\" : \"123a123b\"\r\n        }" +
                "\r\n\r\n    ]\r\n}";
            string sUrl = "http://httpbin.org/post";
            string sAuth_ID = string.Empty;

            TJson testjson = new TJson();
            testjson.APIJSONTEST(Post, sUrl, out sAuth_ID);

            #endregion

            #region Test Hit Success

            //string Post = "\"Auth_Type\" : [\r\n{\r\n\"Auth_Name\" : \"Setoran\",\r\n\"Auth_Pass\" : \"123a123b\"";
            //string sStatus = string.Empty;
            //string sUrl = "http://httpbin.org/post";

            //TJson testjson = new TJson();
            //testjson.APIJSONTEST(Post,sUrl,out sStatus);

            #endregion


            #endregion



        }
        #endregion
        //static void Main(string[] args)
        //{


        //    string Post = "\"Auth_Type\" : [\r\n{\r\n\"Auth_Name\" : \"Setoran\",\r\n\"Auth_Pass\" : \"123a123b\"";
        //    string sStatus = string.Empty;
        //    string sUrl = "http://httpbin.org/post";

        //    TJson testjson = new TJson();
        //    testjson.APIJSONTEST(Post, sUrl, out sStatus);

        //    Console.ReadLine();


        //    //JObject jObject = JObject.Parse(json);
        //    //var status = jObject["status"];


        //}
    }
}
