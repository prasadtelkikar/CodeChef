using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/MUFFINS3
    /// </summary>
    public class MUFFINS3
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                var result = input / 2 + 1;
                results.Add(result);
            }
            Console.WriteLine(string.Join(" ", results));
            Console.ReadLine();
        }
    }
}