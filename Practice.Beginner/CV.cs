using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CV
    /// </summary>
    public class CV
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] consonent = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            var results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                string input = Console.ReadLine();
                int count = 0;
                for (int j = 0; j < length - 1; j++)
                {
                    if (consonent.Any(x => x == input[j]) && vowels.Any(x => x == input[j + 1]))
                        count++;
                }
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}