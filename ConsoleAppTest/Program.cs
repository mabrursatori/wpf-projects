using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Todd", "Howard" };
            int[] age = {25,60 };

            Console.WriteLine( names.Zip(age, (names, age) => names + "" + age + "years old")); 

        }
    }
}
