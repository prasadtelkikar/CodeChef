using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PLAYSTR
    /// </summary>
    public class PLAYSTR
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();

                int firstOnce = firstStr.Count(x => x == '1');
                int firstZero = firstStr.Length - firstOnce;
                int secondOnce = secondStr.Count(x => x == '1');
                int secondZero = secondStr.Length - secondOnce;

                if (firstOnce == secondOnce && firstZero == secondZero)
                    results.Add("YES");
                else
                    results.Add("NO");
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}