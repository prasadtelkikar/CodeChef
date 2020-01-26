using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/LTM40AB
    /// </summary>
    public class LTM40AB
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int count = GetCount(array);
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static int GetCount(int[] array)
        {
            int count = 0;
            for (int i = array[0]; i <= array[1]; i++)
            {
                for (int j = array[2]; j <= array[3]; j++)
                {
                    if (i < j)
                        count++;
                }
            }
            return count;
        }
    }
}