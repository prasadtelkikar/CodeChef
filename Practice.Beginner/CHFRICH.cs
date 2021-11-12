using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class CHFRICH
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var result = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var output = (inputs[1] - inputs[0]) / inputs[2];
                result.Add(output);
            }
            Console.WriteLine(String.Join(Environment.NewLine, result.ToArray()));
        }
    }
}
