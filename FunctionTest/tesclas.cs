using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTest
{
    class tesclas
    {

        public static int returnKD(int noKartu) /* Input */
        {
            //==============================
            //int KodeKartu = 0;
            //KodeKartu = noKartu;
            ////Jika False Balik ke halaman Input Jika true Memulai Transaksi

            ////returning NoKartu

            //return KodeKartu.ToString(); /*balikan */

            //===============================


            ////data masuk di tambah 100
            int a = 0;
            a = noKartu + 100;



            ////tampilkan hasil

            return a;

        }

        public static string GetnoKartu /* Balikkan  */(int noKartu) /* Input */
        {
            // Requesting NoKartu yang nanti berformat int
            int KodeKartu = 0;
            KodeKartu = noKartu;
            //Jika False Balik ke halaman Input Jika true Memulai Transaksi

            //returning NoKartu

            return KodeKartu.ToString();
        }

        public static int GetInputKodePin (int InputDigit)
        {
            // Mendapatkan Data Input Angka
            int InputKode = 0;
            InputKode = InputDigit;
            // Returning Kode Input Untuk Memuai Transaksi
            return InputKode;
        }

        public static int WaitnoKartu(bool BalikkanKartu, int NoKartu) /*Input */
        {
            int Balikkan = 0;
            
            //True Lanjut Transaksi Klo False balikkan Input
            while (BalikkanKartu) 
            {
                GetnoKartu/* metode request */(NoKartu);// Butuh masukan
            }

            return Balikkan;

        }

        public static int TestTrue(bool R1,int Angka)
        {
            int text ;
            text = Angka;
            while (R1)
            {
                
            }

            return text;


        }

        public static string ApaIni (int A)
        {
            int Baka = 20;
            Baka = A + 30 ;
            return Baka.ToString();

        }

        public static string ApaIniString(string A)
        {
            string Baka;
            Baka = A + 30;
            return Baka;


        }
    }
}
