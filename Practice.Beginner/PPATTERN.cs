using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PPATTERN
    /// </summary>
    public class PPATTERN
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                StringBuilder sb = new StringBuilder();
                int count = 1;
                for (int j = 0; j < input; j++)
                {
                    for (int k = 0; k < input; k++)
                    {
                        sb.Append($"{count++} ");
                    }
                    sb.ToString().Trim();
                    sb.Append(Environment.NewLine);
                }
                sb.ToString().Trim();
                results.Add(sb.ToString());
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}