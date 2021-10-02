using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class FLOW016
    {
        public static long FindGCD(long a, long b)
        {
            if(a == 0)
                return b;
            return FindGCD(b % a, a);
        }

        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), long.Parse);
                var mult = inputs[0] * inputs[1];
                var gcd = FindGCD(inputs[0], inputs[1]);
                var lcm = mult / gcd;
                Console.WriteLine(gcd +" "+lcm);
            }
        }
    }
}