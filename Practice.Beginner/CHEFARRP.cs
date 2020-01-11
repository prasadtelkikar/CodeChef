using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    public class CHEFARRP
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int count = 0;
                for (int j = 0; j <= length; j++)
                {
                    for (int k = j + 1; k <= length; k++)
                    {
                        var subArray = array.ToList().GetRange(j, k - j);
                        if (subArray.Count() == 1)
                            continue;

                        var temp = string.Join(",", subArray);
                        int sum = subArray.Sum();
                        int product = subArray.Aggregate(1, (a, b) => a * b);
                        if (sum == product)
                            count++;
                    }
                }
                count += length;
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}