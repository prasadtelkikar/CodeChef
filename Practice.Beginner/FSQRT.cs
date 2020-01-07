using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FSQRT
    /// </summary>
    public class FSQRT
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<double> results = new List<double>();

            for (int i = 0; i < testCases; i++)
            {
                var value = Convert.ToDouble(Console.ReadLine());
                results.Add(Math.Round(Math.Sqrt(value)));
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}