using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/RPD
    /// </summary>
    public class RPD
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var maxResult = int.MinValue;
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        if (j != k)
                        {
                            var mul = array[j] * array[k];
                            var result = mul.ToString().Select(x => (int)x - 48);
                            var sum = 0;
                            foreach (var item in result)
                                sum += item;

                            maxResult = sum > maxResult ? sum : maxResult;
                        }
                    }
                }
                results.Add(maxResult);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}