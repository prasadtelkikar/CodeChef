using System;
using System.Linq;

namespace Practice.Beginner
{
    public class SUMPOS
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var maxValue = inputs.Max();
                var firstNumber = inputs.Min();
                var secondNumber = maxValue - firstNumber;
                var output = inputs.Contains(secondNumber) ? "YES" : "NO";
                result[i] = output;
            }
            Console.WriteLine(String.Join(Environment.NewLine, result));
        }
    }
}
