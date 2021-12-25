using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner_I
{
    public class HE_Sum_Frequency
    {
        public static void Main(string[] args)
        {
            var arraySize = int.Parse(Console.ReadLine()); 
            var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var testCases = int.Parse(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var range = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var lowerLimit = range[0];
                var upperLimit = range[1];

                var result = CountFrequencyWithArraySum(inputs, lowerLimit, upperLimit);
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
        }

        //Only one test case passed, rest of the test case result : Time limit exceeded
        public static int CountFrequencySumLinq(int[] inputs, int lowerLimit, int upperLimit)
        {
            var result = inputs.GroupBy(x => x)
                .Where(x => x.Count() >= lowerLimit && x.Count() <= upperLimit)
                .Aggregate(0, (total, next) => total + (next.Key * next.Count()));
            return result;
        }

        //Only one test case passed, rest of the test case result : Time limit exceeded
        public static int CountFrequencySumDict(int[] inputs, int lowerLimit, int upperLimit)
        {
            Dictionary<int, int> countNumbers = new Dictionary<int, int>();
            int sum = 0;
            foreach (var input in inputs)
            {
                if (countNumbers.ContainsKey(input))
                    countNumbers[input]++;
                else
                    countNumbers.Add(input, 1);
            }
            foreach (var kvp in countNumbers)
            {
                if (kvp.Value >= lowerLimit && kvp.Value <= upperLimit)
                    sum +=(kvp.Key * kvp.Value);
            }
            return sum;
        }

        //Cheated: Checked editorial

        public static int CountFrequencyWithArraySum(int[] inputs, int lowerLimit, int upperLimit)
        {
            int[] sum = new int[1000001];
            int[] frequency = new int[1000001];
            var result = 0;
            var inputDistinct = new HashSet<int>(inputs);
            foreach (var input in inputs)
            {
                sum[input] += input; 
                frequency[input]++;
            }
            foreach (var hItem in inputDistinct)
            {
                var itemFrequency = frequency[hItem];
                if(itemFrequency >= lowerLimit && itemFrequency <= upperLimit)
                    result += sum[hItem];
            }
            return result;
        }
    }
}
