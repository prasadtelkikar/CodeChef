using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/JDELAY
    /// </summary>
    public class JDELAY
    {
        public static void Main(string[] args)
        {
            int testsCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testsCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                for (int j = 0; j < input; j++)
                {
                    var submissions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int result = submissions[1] - submissions[0];
                    if (result > 5)
                        count++;
                }
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}