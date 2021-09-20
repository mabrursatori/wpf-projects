using System;
using Newtonsoft;
using Newtonsoft.Json;

namespace JsonString
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonData = @"{'FirstName' : 'Yosua', 'LastName' : 'Trivedi'}";

            var myDetails = JsonConvert.DeserializeObject< myDetails >(jsonData);
            Console.WriteLine(string.Concat("Hi ", myDetails.FirstName, "  "+ myDetails.LastName));
            Console.ReadLine();
        }

        public class myDetails
        {
            public string FirstName
            {
                get; set;
            }

            public string LastName
            {
                get; set;
            }
        }
    }
}
