using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW018
    /// </summary>
    public class FLOW018
    {
        public static long FindFoctorial(long number)
        {
            if (number == 0)
                return 1;
            return number * FindFoctorial(number - 1);
        }

        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<long> results = new List<long>();
            for (int i = 0; i < testCases; i++)
            {
                long input = long.Parse(Console.ReadLine());
                var result = FindFoctorial(input);
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}