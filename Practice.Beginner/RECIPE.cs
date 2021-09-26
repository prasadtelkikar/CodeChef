using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Practice.Beginner
{
    /// <summary>
    /// Euclidean GCD: https://www.khanacademy.org/computing/computer-science/cryptography/modarithmetic/a/the-euclidean-algorithm
    /// </summary>
    public class RECIPE
    {
        public static int GetGCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            var temp = a % b;
            return GetGCD(b, temp);
        }
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var length = inputs[0];
                var gcd = 0;
                for(int j = 1; j <=length; j++)
                {
                    gcd = GetGCD(gcd, inputs[j]);
                    
                }
                StringBuilder sb = new StringBuilder();
                foreach(var input in inputs.Skip(1))
                {
                    var result = input / gcd;
                    if (result != 0)
                        sb.Append(result + " ");
                }
                Console.WriteLine(sb.ToString().TrimEnd());
            }

        }
    }
}
