using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW004
    /// </summary>
    public class FLOW004
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            int asciiZero = 48;
            for (int i = 0; i < testCases; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                int lastIndex = input.Length - 1;
                int result = ((int)input[0] - asciiZero) + ((int)input[lastIndex] - asciiZero);
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}