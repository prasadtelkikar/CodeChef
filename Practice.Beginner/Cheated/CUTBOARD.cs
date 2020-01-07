using System;
using System.Collections.Generic;

namespace Practice.Beginner.Cheated
{
    /// <summary>
    /// https://www.codechef.com/problems/CUTBOARD
    /// </summary>
    public class CUTBOARD
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int result = (array[0] - 1) * (array[1] - 1);
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}