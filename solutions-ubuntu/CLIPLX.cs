using System;

namespace solutions_ubuntu
{
    public class CLIPLX
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            for(int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var totalMatches = inputs[0];
                var remainingMatches = inputs[1];

                Console.WriteLine(Math.Max(0, totalMatches - remainingMatches));
            }
        }
    }
}