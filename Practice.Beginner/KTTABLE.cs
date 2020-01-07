using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/KTTABLE
    /// </summary>
    public class KTTABLE
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int initialTime = 0;
                int result = 0;
                var kitchenTimes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var cookingTimes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for (int j = 0; j < length; j++)
                {
                    var requiredTime = kitchenTimes[j] - initialTime;
                    initialTime = kitchenTimes[j];
                    if (requiredTime >= cookingTimes[j])
                        result++;
                }
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}