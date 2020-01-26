using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/STRLBP
    /// </summary>
    public class STRLBP
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                string isUniform = IsStringUniform(input);
                results.Add(isUniform);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static string IsStringUniform(string input)
        {
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                if ((input[i] == '0' && input[i + 1] == '1') || (input[i] == '1' && input[i + 1] == '0'))
                    count++;

                if (count > 2)
                    return "non-uniform";
            }
            return "uniform";
        }
    }
}