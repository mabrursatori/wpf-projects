using System;
using System.Collections.Generic;

class Kodify_Example
{
    static void Main()
    {
        Dictionary<int, List<string>> scores = new Dictionary<int, List<string>>();

        scores.Add(200, new List<string>() { "Sarah", "Meghan" });
        scores.Add(195, new List<string>() { "Calvin", "Michelle" });
        scores.Add(201, new List<string>() { "Sebastian" });
        scores.Add(225, new List<string>() { "Mike" });

        // Loop through all scores, and see who scored that
        foreach (var score in scores)
        {
            Console.Write("Score: {0} points | ", score.Key);

            foreach (var person in score.Value)
            {
                Console.Write("{0}\t", person);
            }

            Console.Write("\n");
        }
    }
}