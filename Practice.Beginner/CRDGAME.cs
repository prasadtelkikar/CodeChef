using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class CRDGAME
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var rounds = Convert.ToInt32(Console.ReadLine());
                int chefCount = 0;
                int mortyCount = 0;
                for (int j = 0; j < rounds; j++)
                {
                    var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                    var sum1 = SumOfDigits(inputs[0]);
                    var sum2 = SumOfDigits(inputs[1]);
                    if (sum1 > sum2)
                        chefCount++;
                    else if (sum1 < sum2)
                        mortyCount++;
                    else
                    {
                        chefCount++;
                        mortyCount++;
                    }
                }

                results.Add(GetResult(chefCount, mortyCount));
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        public static long SumOfDigits(long number)
        {
            long result = 0;
            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }

        private static string GetResult(int chefCount, int mortyCount)
        {
            string result = string.Empty;
            if (chefCount > mortyCount)
                return $"{0} {chefCount}";
            else if (chefCount < mortyCount)
                return $"{1} {mortyCount}";
            else
                return $"{2} {mortyCount}";
        }
    }
}