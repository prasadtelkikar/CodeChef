using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PRB01
    /// </summary>
    public class PRB01
    {
        public static IList<int> FindPrimesBySeiveOfEratosthenes()
        {
            bool[] testData = new bool[10001];
            List<int> primeNumbers = new List<int>();

            for (int i = 0; i < 10001; i++)
                testData[i] = true;

            for (int i = 2; i * i < 10001; i++)
            {
                if (testData[i])
                {
                    for (int j = i * i; j < 10001; j += i)
                        testData[j] = false;
                }
            }
            for (int i = 2; i < 10001; i++)
                if (testData[i])
                    primeNumbers.Add(i);

            return primeNumbers;
        }

        public static void Main(string[] args)
        {
            IList<int> primeNumbers = FindPrimesBySeiveOfEratosthenes();
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                var result = primeNumbers.Any(x => x == input) ? "yes" : "no";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}