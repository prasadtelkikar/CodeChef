using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/LZYG
    /// </summary>
    public class LZYG
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<double>();
            for (var i = 0; i < testCases; i++)
            {
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                var time = 0.0;
                var nextInterval = 0.0;
                var count = 0;
                var tasks = 0.0;
                while (time <= array[1])
                {
                    count++;
                    nextInterval += array.Last();
                    time++;
                    var remainingTime = nextInterval - time;
                    time += remainingTime;
                    tasks = time;
                    if (time == nextInterval)
                        time += nextInterval;
                }
                results.Add(tasks);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}