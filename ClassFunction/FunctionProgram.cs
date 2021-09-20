using System;
using System.Collections.Generic;

namespace ClassFunction
{
    class FunctionProgram
    {
        static void Main(string[] args)
        {
            var Numbers /*Input */ = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = GetSmallest(Numbers , 3);

            foreach (var number in smallest)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallest (List<int> list, int count)
        {
            var smallest = new List<int>(); // to hold smallest number

            while (smallest.Count < count) // logic data process
            {
                var min = GetSmallest(list);
                smallest.Add(min);
                list.Remove(min);
            }

            return smallest;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }

            return min;
        }
    }
}
