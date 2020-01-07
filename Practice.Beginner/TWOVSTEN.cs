using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL:https://www.codechef.com/problems/TWOVSTEN [Cheated - from editorial] Key behind this program is
    /// divisibility rule of 10 and multiples of 2 Only XX5 * 2 only divisible by 10, XX1, XX2, XX3, XX4, XX6, XX7, XX8,
    /// XX9 are all can NOT divisible by 10 if we multiply value by 2.
    /// </summary>
    public class TWOVSTEN
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                long input = long.Parse(Console.ReadLine());
                if (input % 10 == 0)
                    results.Add(0);
                else if ((input * 2) % 10 == 0)
                    results.Add(1);
                else
                    results.Add(-1);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}