using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner_I
{
    public class GOODBAD
    {
        public static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            var output = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var input = Console.ReadLine();
                var lower = input.ToCharArray().Count(x => char.IsLower(x));
                var upperToLower = nk[0] - lower;
                var lowerToUpper = nk[0] - upperToLower;

                if (nk[1] < lowerToUpper && nk[1] < upperToLower)
                    output.Add("none");
                else if (nk[1] >= lowerToUpper && nk[1] >= upperToLower)
                    output.Add("both");
                else if (nk[1] >= upperToLower)
                    output.Add("chef");
                else if (nk[1] >= lowerToUpper)
                    output.Add("brother");
            }
            Console.WriteLine(string.Join(Environment.NewLine, output));
        }
    }
}
