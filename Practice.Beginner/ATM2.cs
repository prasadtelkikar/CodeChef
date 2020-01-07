using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/ATM2
    /// </summary>
    public class ATM2
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = inputs[0];
                int limit = inputs[1];
                int[] rupees = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < n; j++)
                {
                    if (limit >= rupees[j])
                    {
                        limit -= rupees[j];
                        sb.Append("1");
                    }
                    else
                        sb.Append("0");
                }
                results.Add(sb.ToString());
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}