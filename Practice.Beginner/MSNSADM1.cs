using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/MSNSADM1
    /// </summary>
    public class MSNSADM1
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<int>();

            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var goals = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var foul = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int max = int.MinValue;
                for (int j = 0; j < length; j++)
                {
                    var calculate = goals[j] * 20 - foul[j] * 10;
                    max = calculate > max ? calculate : max;
                }
                if (max <= 0)
                    results.Add(0);
                else
                    results.Add(max);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}