using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/SIMDISH
    /// </summary>
    public class SIMDISH
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var firstIngredients = Console.ReadLine().Split(' ');
                var secondIngredients = Console.ReadLine().Split(' ');
                var result = secondIngredients.Intersect(firstIngredients).Count() >= 2 ? "similar" : "dissimilar";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}