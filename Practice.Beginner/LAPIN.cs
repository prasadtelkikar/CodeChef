using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/LAPIN
    /// </summary>
    public class LAPIN
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                bool islapindrome = true;
                string lapindromes = Console.ReadLine();
                int midIndex = lapindromes.Length / 2;
                var firstArr = lapindromes.Take(midIndex).ToArray();
                var secondArr = lapindromes.Skip(lapindromes.Length - midIndex).ToArray();
                Array.Sort(firstArr);
                Array.Sort(secondArr);
                for (int j = 0; j < midIndex; j++)
                {
                    if (firstArr[j] != secondArr[j])
                    {
                        results.Add("NO");
                        islapindrome = false;
                        break;
                    }
                }
                if (islapindrome)
                    results.Add("YES");
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}