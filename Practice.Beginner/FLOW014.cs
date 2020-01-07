using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW014
    /// </summary>
    public class FLOW014
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int hardness = inputs[0];
                int carbonContent = inputs[1];
                int strength = inputs[2];
                int result = int.MinValue;

                if (hardness > 50 && carbonContent < 0.7 && strength > 5600)
                    result = 10;
                else if (hardness > 50 && carbonContent < 0.7)
                    result = 9;
                else if (carbonContent < 0.7 && strength > 5600)
                    result = 8;
                else if (hardness > 50 && strength > 5600)
                    result = 7;
                else if (hardness > 50 || carbonContent < 0.7 || strength > 5600)
                    result = 6;
                else
                    result = 5;
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}