using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/WATSCORE
    /// </summary>
    public class WATSCORE
    {
        public static IDictionary<int, int> GetDefaultProblem()
        {
            var result = new Dictionary<int, int>();
            result.Add(1, 0);
            result.Add(2, 0);
            result.Add(3, 0);
            result.Add(4, 0);
            result.Add(5, 0);
            result.Add(6, 0);
            result.Add(7, 0);
            result.Add(8, 0);
            return result;
        }

        public static void Main(string[] args)
        {
            List<int> results = new List<int>();
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                IDictionary<int, int> problemScore = GetDefaultProblem();
                int length = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < length; j++)
                {
                    var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    if (problemScore.ContainsKey(inputs[0]))
                        problemScore[inputs[0]] = Math.Max(problemScore[inputs[0]], inputs[1]);
                }
                var maxScore = 0;
                foreach (var kvpair in problemScore)
                    maxScore += kvpair.Value;
                results.Add(maxScore);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}