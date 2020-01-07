using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/DIET
    /// </summary>
    public class DIET
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var requiredCal = inputs[1];
                var initialProtine = 0;
                var protines = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var result = "YES";
                for (int j = 0; j < protines.Length; j++)
                {
                    initialProtine = protines[j] + initialProtine - requiredCal;
                    if (initialProtine < 0)
                    {
                        result = $"NO {j + 1}";
                        break;
                    }
                }
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}