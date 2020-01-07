using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CHEFSTUD
    /// </summary>
    public class CHEFSTUD
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                StringBuilder sb = new StringBuilder();
                foreach (var ch in input)
                {
                    if (ch == '>')
                        sb.Append('<');
                    else if (ch == '<')
                        sb.Append('>');
                    else
                        sb.Append(ch);
                }
                input = sb.ToString();
                int count = Regex.Matches(input, "><").Count;
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}