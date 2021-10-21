using System;
using System.Linq;
using System.Collections.Generic;

namespace  solutions_ubuntu
{
    public class LUCKYNUM
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            var result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var inputs = Console.ReadLine().Trim().Split();
                result.Add(inputs.Any(x => x == "7") ? "YES": "NO");
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}