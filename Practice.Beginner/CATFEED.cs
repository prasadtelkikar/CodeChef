using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CATFEED
    /// </summary>
    public class CATFEED
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var isSuccessful = true;
                for (int j = 0; j < inputs[1]; j += inputs[0])
                {
                    var tempArr = arr.Skip(j).Take(inputs[0]).ToArray();
                    if (tempArr.Length != tempArr.Distinct().Count())
                    {
                        isSuccessful = false;
                        break;
                    }
                }
                var result = isSuccessful ? "YES" : "NO";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}