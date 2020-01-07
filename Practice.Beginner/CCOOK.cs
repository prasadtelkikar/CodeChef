using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CCOOK
    /// </summary>
    public class CCOOK
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var developerLevel = new List<string>() { "Beginner", "Junior Developer", "Middle Developer", "Senior Developer", "Hacker", "Jeff Dean" };
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int sum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).Sum();
                results.Add(developerLevel[sum]);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}