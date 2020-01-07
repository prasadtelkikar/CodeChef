using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW008
    /// </summary>
    public class FLOW008
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                var result = input < 10 ? "What an obedient servant you are!" : "-1";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}