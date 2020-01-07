using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/SNCKYEAR
    /// </summary>
    public class SNCKYEAR
    {
        public static void Main(string[] args)
        {
            List<int> hostedYears = new List<int>() { 2010, 2015, 2016, 2017, 2019 };
            var input = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input; i++)
            {
                var inputYear = Convert.ToInt32(Console.ReadLine());
                var result = hostedYears.Contains(inputYear) ? "" : "NOT ";
                sb.Append($"{result}HOSTED{Environment.NewLine}");
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}