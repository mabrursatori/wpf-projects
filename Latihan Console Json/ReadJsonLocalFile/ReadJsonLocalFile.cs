using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Web;

namespace ReadJsonLocalFile
{
    public class ReadJsonLocalFile
    {
        public class Parameter
        {
            public string layout { get; set; }
            public int timeoutUserIdle { get; set; }
            public int escrowMaxCount { get; set; }
            public int machineTimeout { get; set; }
            public int serialMagstripe { get; set; }
            public string portMagStripe { get; set; }
            public string urlWebService { get; set; }
            public string machineName { get; set; }
            public int remotePollInterval { get; set; }
            public bool UseOTP { get; set; }

        }

        public class TheHit 
        {
            public bool HitLocalJson(string Json, out string use)
            {
                //string Use = string.Empty;
                //string Json = @"D:\Notepad\Json\parameter.json";
                bool Condition = false;
                
                //string filepath = @"D:\Notepad\Json\parameter.json";
                string Result = string.Empty;
                string Write = string.Empty;
                using (StreamReader r = new StreamReader(Json))
                {
                    var jsonRes = r.ReadToEnd();
                    var jobj = JObject.Parse(jsonRes);
                    Result = jobj.ToString();
                    Write = jobj.ToString();
                    //Console.WriteLine(Write);
                }

                dynamic json = JsonConvert.DeserializeObject(Result);
                use = json.UseOTP;
                if (use == "True")
                {
                    Console.WriteLine("True, this thing worked then");
                }
                else
                {
                    Console.WriteLine("Check Again, something must be wrong");
                }

                return Condition;
            }
        }

       

        public static void rwr()
        {
            string filepath = @"D:\Notepad\Json\parameter.json";
            string Result = string.Empty;
            string Write = string.Empty;
            using (StreamReader r = new StreamReader(filepath))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                Result = jobj.ToString();
                Write = jobj.ToString();
                Console.WriteLine(Write);
            }
            //Console.WriteLine(Result);
            //File.WriteAllText(filepath, Write);
        }

        static void Main(string[] args)
        {
            string Use = string.Empty;
            string Json = @"D:\Notepad\Json\parameter.json";

            TheHit hit = new TheHit();
            hit.HitLocalJson(Json, out Use);
            //rwr();
            Console.ReadLine();
        }
    }
}
