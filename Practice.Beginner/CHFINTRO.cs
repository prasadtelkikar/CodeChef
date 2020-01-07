using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CHFINTRO
    /// </summary>
    public class CHFINTRO
    {
        public static void Main(string[] args)
        {
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int testCases = inputs[0];
            int knownRating = inputs[1];
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                string result = input < knownRating ? "Bad boi" : "Good boi";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}