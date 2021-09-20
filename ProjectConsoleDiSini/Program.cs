using ClassLibraryTest;
using System;
using System.Net;

namespace ProjectConsoleDiSini
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new WebClient();
            //var content = client.DownloadString("http://localhost:51770/WebService1.asmx");

            /*         Metode Requeste Sudah Benar                 */

            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] =
                   "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                byte[] arr = client.DownloadData("http://localhost:51770/WebService1.asmx");

                // Write values.
                Console.WriteLine("--- WebClient result ---");
                Console.WriteLine(arr.Length);
            }

            //==========================================================================

            //Car myOBJ = new Car();
            //Console.WriteLine(myOBJ.color);
        }
    }
}
