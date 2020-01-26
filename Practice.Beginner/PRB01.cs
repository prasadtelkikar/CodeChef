using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PRB01
    /// </summary>
    public class PRB01
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                bool isPrime = IsPrimeNumber(input);
                results.Add(isPrime ? "yes" : "no");
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int input)
        {
            for (int i = 2; i < input; i++)
                if (input % i == 0)
                    return false;

            return true;
        }
    }
}