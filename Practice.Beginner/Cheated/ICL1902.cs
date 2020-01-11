using System;
using System.Collections.Generic;

namespace Practice.Beginner.Cheated
{
    /// <summary>
    /// https://www.codechef.com/problems/ICL1902
    /// </summary>
    public class ICL1902
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                int count = 0;
                while (number > 0)
                {
                    int square = (int)Math.Sqrt(number);
                    count++;
                    number = number - square * square;
                }
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}