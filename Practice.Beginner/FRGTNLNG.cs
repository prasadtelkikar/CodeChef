using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FRGTNLNG
    /// </summary>
    public class FRGTNLNG
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                HashSet<string> forgottonWords = new HashSet<string>(Console.ReadLine().Split(' '));
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < inputs[1]; j++)
                {
                    var strings = Console.ReadLine().Split(' ').Skip(1);
                    sb.Append(string.Join(" ", strings));
                    sb.Append(" ");
                }

                HashSet<string> phrases = new HashSet<string>(sb.ToString().Trim().Split(' '));
                StringBuilder result = new StringBuilder();
                foreach (var forgottonWord in forgottonWords)
                    result.Append(phrases.Contains(forgottonWord) ? "YES " : "NO ");

                results.Add(result.ToString().Trim());
            }

            Console.Write(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}