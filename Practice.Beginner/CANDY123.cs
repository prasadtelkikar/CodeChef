using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CANDY123
    /// </summary>
    public class CANDY123
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                string result = GetCandyLover(inputs[0], inputs[1]);
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static string GetCandyLover(int maxLimak, int maxBob)
        {
            int initialA = 0;
            int initialB = 0;
            //for (int i = 1; i < 1001; i++)
            foreach (var i in Enumerable.Range(1, 1001))
            {
                if (i % 2 == 0)
                    initialB += i;
                else
                    initialA += i;

                if (initialA > maxLimak)
                    return "Bob";
                if (initialB > maxBob)
                    return "Limak";
            }
            return "";
        }
    }
}