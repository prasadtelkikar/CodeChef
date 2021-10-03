using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class RECTANGL
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                Array.Sort(inputs);
                var isRectangle = inputs[0] == inputs[1] && inputs[2] == inputs[3];

                Console.WriteLine(isRectangle ? "YES" : "NO");
            }
        }
    }
}