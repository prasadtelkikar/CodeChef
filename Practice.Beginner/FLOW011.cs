using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class FLOW011
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var basics = int.Parse(Console.ReadLine());
                double sal = basics < 1500
                    ? (basics + (0.1 * basics) + (0.9 * basics))
                    : (basics + 500 + (0.98 * basics));
                Console.WriteLine(sal);
            }

        }
    }
}
