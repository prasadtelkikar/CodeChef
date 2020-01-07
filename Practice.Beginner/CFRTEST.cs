using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CFRTEST
    /// </summary>
    public class CFRTEST
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int numberOfFrinds = Convert.ToInt32(Console.ReadLine());
                int savedFriendCount = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Distinct().Count();

                results.Add(savedFriendCount);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}