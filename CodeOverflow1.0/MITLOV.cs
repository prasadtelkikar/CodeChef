using System;
using System.Numerics;

namespace CodeOverflow1._0
{
    public class MITLOV
    {
        public static void Main(string[] args)
        {
            BigInteger buns = new BigInteger();
            BigInteger cheese = new BigInteger();
            BigInteger.TryParse(Console.ReadLine(), out buns);
            BigInteger.TryParse(Console.ReadLine(), out cheese);

            BigInteger result = cheese * buns;
            Console.WriteLine(result);
        }
    }
}