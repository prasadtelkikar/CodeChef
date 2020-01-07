using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CO92JUDG
    /// </summary>
    public class CO92JUDG
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var alice = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var bob = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                var aliceOptimalSum = alice.Sum() - alice.Max();
                var bobOptimalSum = bob.Sum() - bob.Max();

                string result = aliceOptimalSum > bobOptimalSum ? "Bob" : bobOptimalSum > aliceOptimalSum ? "Alice" : "Draw";

                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}