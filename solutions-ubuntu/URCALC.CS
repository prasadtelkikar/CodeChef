using System;

namespace solutions_ubuntu
{
    //This solution is failing, but python is working fine.
    public class URCALC
    {
        public static void Main(string[] args)
        {
            var numerator = int.Parse(Console.ReadLine());
            var denominator = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();

            if(oper == "+")
                Console.WriteLine(numerator + denominator);
            else if(oper == "-")
                Console.WriteLine(numerator - denominator);
            else if(oper == "*")
                Console.WriteLine(numerator * denominator);
            else
                Console.WriteLine((numerator / (float)denominator).ToString("#.##"));
        }
    }
}