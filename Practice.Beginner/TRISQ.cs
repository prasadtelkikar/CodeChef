using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/TRISQ
    /// </summary>
    public class TRISQ
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                while (input >= 0)
                {
                    result += (input / 2 - 1);
                    input -= 2;
                }

                results.Add(result + 1);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}