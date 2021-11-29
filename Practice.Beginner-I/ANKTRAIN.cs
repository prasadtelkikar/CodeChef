using System;
using System.Collections.Generic;

namespace Practice.Beginner_I
{
    public class ANKTRAIN
    {
        public static void Main(string[] args)
        {
            var sittingArrangement = new List<string>() { "SL", "LB", "MB", "UB", "LB", "MB", "UB", "SU" };
            var testCases = int.Parse(Console.ReadLine());
            var result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var block = input % 8;
                string sit;
                if (block == 0)
                    sit = $"{input - 1}SL";
                else if (block == 7)
                    sit = $"{input + 1}SU";
                else
                {
                    if (block >= 1 && block <= 3)
                        sit = $"{input + 3}{sittingArrangement[block]}";
                    else
                        sit = $"{input - 3}{sittingArrangement[block]}";
                }
                result.Add(sit);
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
