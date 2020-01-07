using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL: https://www.codechef.com/problems/LUCKFOUR
    /// </summary>
    public class LUCKFOUR
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < input; i++)
                results.Add(Console.ReadLine().Select(x => Convert.ToInt32(x.ToString())).Count(x => x == 4));

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}