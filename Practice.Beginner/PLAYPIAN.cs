using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PLAYPIAN
    /// </summary>
    public class PLAYPIAN
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                string result = "yes";
                for (int j = 0; j < input.Length - 1; j = j + 2)
                {
                    char firstLetter = input[j];
                    char secondLetter = input[j + 1];
                    if (firstLetter == secondLetter)
                    {
                        result = "no";
                        break;
                    }
                }
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}