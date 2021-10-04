using System;

namespace solutions_ubuntu
{
    public class HOWMANY
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim();
            var length = input.Length;
            if(length > 3)
                Console.WriteLine("More than 3 digits");
            else
                Console.WriteLine(length);
        }
    }
}