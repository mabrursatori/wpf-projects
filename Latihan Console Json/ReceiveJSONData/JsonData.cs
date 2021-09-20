using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

namespace ReceiveJSONData
{
    class Program
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

        public static void Main(string[] args )
        {
            string URL = "http://192.168.8.40:30003/authwsdl/";

                try

                {

                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(URL);

                myReq.Method = "GET";

                myReq.ContentType = "application/json";

                myReq.Accept = "application/json";

              

                WebResponse myResponse = myReq.GetResponse();

                Stream rebut = myResponse.GetResponseStream();

                StreamReader readStream = new StreamReader(rebut, Encoding.UTF8);

                string info = readStream.ReadToEnd();

                myResponse.Close();

                readStream.Close();



                

                //Response.Write(info);

            }



            catch (Exception e1)

            {

                Console.Out.WriteLine("-----------------");

                Console.Out.WriteLine(e1.Message);

                Console.Write(e1.ToString());

                Console.Read();

            }

        }
    }
}

