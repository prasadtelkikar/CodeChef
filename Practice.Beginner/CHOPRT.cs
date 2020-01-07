using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL: https://www.codechef.com/problems/CHOPRT
    /// </summary>
    public class CHOPRT
    {
        public static void Main(string[] arg)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < testCases; i++)
            {
                var result = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                sb.Append((result[0] < result[1]) ? "<" : (result[0] > result[1]) ? ">" : "=");
                sb.Append(Environment.NewLine);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}