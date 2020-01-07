using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL: https://www.codechef.com/problems/MATCHES
    /// </summary>
    public class MATCHES
    {
        public static void Main(string[] args)
        {
            int[] matches = new int[] { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
            List<int> results = new List<int>();
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                long sumOfTwoNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse).Sum();
                var indexes = sumOfTwoNumbers.ToString().Select(x => int.Parse(x.ToString()));

                var result = indexes.Aggregate(0, (x1, x2) => x1 + matches[x2]);

                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}