using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class FLOW009
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                var totalPrice = inputs[0] * inputs[1];
                if (inputs[0] > 1000)
                    totalPrice -= totalPrice * 0.1;
                result.Add(totalPrice.ToString("0.000000"));
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}