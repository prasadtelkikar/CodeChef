using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner_I
{
    public class SIMPSTAT
    {
        //Buggy
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var length = nk[0];
                var k = nk[1];
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
                inputs.Sort();
                var sum = inputs.Skip(k).Take(length - (2 * k)).Sum();

                var result = ((double)sum / (length - k*2)).ToString("#.######");

                results.Add(result);
            }
            Console.WriteLine(String.Join(Environment.NewLine, results));
        }
    }
}
