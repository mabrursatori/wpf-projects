using System;
using System.Web.Http.SelfHost;

namespace SelfHost
{
    class Program
    {
        public class Response
        {
            public string status { get; set; }
            public string ID { get; set; }
            public string name { get; set; }
            public string position { get; set; }

        }


        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            //To determine which action to invoke, the framework uses a routing table. The Visual Studio project template for Web API creates a default route  

            config.Routes.MapHttpRoute(

                "API Default", "api/{controller}/{id}",

                new { id = RouteParameter.Optional });

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))

            {

                server.OpenAsync().Wait();



                Console.WriteLine("Listening for HTTP requests.");

                Console.WriteLine("(Please Run the ClientApp project to send requests).");

                Console.WriteLine();

                Console.WriteLine("You can hit Enter to quit.");

                Console.ReadLine();
            }
        }
    }
