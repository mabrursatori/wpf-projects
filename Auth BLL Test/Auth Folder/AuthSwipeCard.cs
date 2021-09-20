using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Auth_BLL_Test.Auth_Folder
{
    public class AuthSwipeCard
    {
       

        public void HittinURL()
            {
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] =
                   "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";

                byte[] arr = client.DownloadData("http://localhost:51770/WebService1.asmx");
                
            }
               

            }



    }

    public class FunctionRequestNoKartu
    {
        // public string ReturnKD(int KodeKartu)
        //{
        //    return KodeKartu.ToString();
        //}

        public int KodeKartu (int noIDKartu)
        {
            int a = 15;
            a = noIDKartu;
            return a;

        }

    }

    public static class IntTest
    {
        public static int returnKD(int noKartu)
        {
            int a = 0;
            a = noKartu + 100;

            return a;

        }

        //public void HasilKartu()
        //{
        //    int c;
        //    c = returnKD(15);
        //}

    }

    public class Car
    {
       public string color = "red";

    }

    public class ReturnDebitString /* hasil balikkan */   /*(int noKartu*) /* Input nya */
    {
        public string returnKD2 /* hasil balikkan */   (int noKartu) /* Input nya */
        {
            int a = 0;
            String b;
            a = noKartu + 100;
            b = a.ToString();

            return b;
            // ini di class
        }
        // ini di class
    }

    public class HitWSDL
    {
        

        public void HITWSDLCODE()
        {
            
        }
       
        
    }
}
