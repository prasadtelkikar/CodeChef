using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/MDL
    /// </summary>
    public class MDL
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                var maxValue = array.Max();
                var minValue = array.Min();

                var indexOfMaxValue = Array.FindIndex(array, x => x == maxValue);
                var indexOfMinValue = Array.FindIndex(array, x => x == minValue);

                var result = indexOfMinValue < indexOfMaxValue ? $"{minValue} {maxValue}" : $"{maxValue} {minValue}";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}