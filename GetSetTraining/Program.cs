using System;
using System.Data.SqlTypes;
using System.Linq;

namespace GetSetTraining
{
    class Program
    {
        public static int angka1 (bool r1, int angka)
        {
            int text = 0;
            text = angka;
            while (r1)
            {
                Console.WriteLine("",text);
            }

            return text;
        }

        static void Main(string[] args)
        {
            bool r1 = true;
            int angka = 10;
            int text = 0;
            text = angka;
            while (r1)
            {
                Console.WriteLine("", text);
            }

            

            Console.WriteLine("");
        }
    }
}
