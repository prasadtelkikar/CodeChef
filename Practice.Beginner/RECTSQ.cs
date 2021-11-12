using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    public class RECTSQ
    {
        public static int FindGCD(int a, int b)
        {
            //Always pass highest number as a
            if(b > a)
                return FindGCD(b, a);
            //If b = 0, that means you got GCD
            if (b == 0)
                return a;
            //otherwise pass b, remainder of a / b
            return FindGCD(b, a % b);
        }
        public static void Main(string[] args)
        {
            var result = new List<int>();
            var testCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var gcd = FindGCD(inputs[0], inputs[1]);
                
                var tcResult = (inputs[0] / gcd) * (inputs[1] / gcd);
                result.Add(tcResult);
            }
            Console.WriteLine(String.Join(Environment.NewLine, result.ToArray()));
        }
    }
}
