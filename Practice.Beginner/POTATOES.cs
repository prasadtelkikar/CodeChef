using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/POTATOES
    /// </summary>
    public class POTATOES
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();

            for (int i = 0; i < testCases; i++)
            {
                var sum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Sum();
                var result = FindNextPrimeNumber(sum);
                results.Add(result - sum);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static int FindNextPrimeNumber(int number)
        {
            int input = number;
            while (true)
            {
                input++;
                if (isPrime(input))
                    return input;
            }
        }

        private static bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}