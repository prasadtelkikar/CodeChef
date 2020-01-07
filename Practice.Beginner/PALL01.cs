using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PALL01
    /// </summary>
    public class PALL01
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine();
                string result = input == string.Join("", input.Reverse()) ? "wins" : "losses";
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}