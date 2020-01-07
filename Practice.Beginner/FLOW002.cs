using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL: https://www.codechef.com/problems/FLOW002
    /// </summary>
    public class FLOW002
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                results.Add(arr[0] % arr[1]);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}