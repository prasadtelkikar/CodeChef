using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/BIT2A
    /// </summary>
    public class BIT2A
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int max = inputs.Max();
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < inputs.Length; j++)
                {
                    var length = inputs.Length - j;
                    if (max == inputs[j])
                    {
                        var zeros = Enumerable.Repeat(0, length);
                        sb.Append(string.Join(" ", zeros));
                        break;
                    }
                    else
                        sb.Append($"{length - 1} ");
                }
                results.Add(sb.ToString().TrimEnd());
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}