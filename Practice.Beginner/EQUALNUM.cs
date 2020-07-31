using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class EQUALNUM
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Console.ReadLine().Split(' ');
                var internationalNumber = inputs[0].Replace(",", string.Empty);
                var indianNumber = inputs[1].Replace(",", string.Empty);
                var r = internationalNumber == indianNumber ? "equal" : "different";
                result.Add(r);
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}