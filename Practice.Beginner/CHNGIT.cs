using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// Question was uncleared, solved after reading editorial https://discuss.codechef.com/t/chngit-editorial/46604
    /// </summary>
    public class CHNGIT
    {
        public static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int count = int.Parse(Console.ReadLine());
                Dictionary<int, int> counts = new Dictionary<int, int>();
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                foreach (var input in inputs)
                {
                    if (counts.ContainsKey(input))
                        counts[input]++;
                    else
                        counts.Add(input, 1);
                }
                var maxCount = int.MinValue;
                foreach (var kvp in counts)
                    maxCount = Math.Max(maxCount, kvp.Value);

                results.Add(count - maxCount);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}