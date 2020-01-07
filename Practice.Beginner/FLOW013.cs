using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW013
    /// </summary>
    public class FLOW013
    {
        public static void Main(string[] args)
        {
            List<string> results = new List<string>();
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int sum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Sum();
                string result = sum == 180 ? "YES" : "NO";
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}