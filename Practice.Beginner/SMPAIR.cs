using System;
using System.Linq;

namespace Practice.Beginner
{
    public class SMPAIR
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                var length = int.Parse(Console.ReadLine());
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
                inputs.Sort();
                Console.WriteLine(inputs[0] + inputs[1]);
            }
        }
    }
}
