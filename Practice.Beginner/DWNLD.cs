using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/DWNLD
    /// </summary>
    public class DWNLD
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                List<InternetData> internetInputs = new List<InternetData>();
                var remainingData = inputs[1];
                for (int j = 0; j < inputs[0]; j++)
                {
                    var data = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    var internetInput = new InternetData(data[0], data[1]);
                    internetInputs.Add(internetInput);
                }
                var result = 0;
                foreach (var item in internetInputs)
                {
                    if (remainingData != 0)
                    {
                        if (remainingData > item.Usage)
                        {
                            remainingData -= item.Usage;
                            item.Usage = 0;
                        }
                        else
                        {
                            item.Usage -= remainingData;
                            remainingData = 0;
                        }
                    }
                    result += item.Usage * item.Cost;
                }
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }

    public class InternetData
    {
        public InternetData(int usage, int cost)
        {
            this.Cost = cost;
            this.Usage = usage;
        }

        public int Cost { get; set; }

        public int Usage { get; set; }
    }
}