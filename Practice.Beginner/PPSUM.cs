using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PPSUM
    /// </summary>
    public class PPSUM
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (inputs[0] == 1)
                    results.Add(Sum(inputs[1]));
                else if (inputs[0] == 2)
                    results.Add(Sum(Sum(inputs[1])));
                else if (inputs[0] == 3)
                    results.Add(Sum(Sum(Sum(inputs[1]))));
                else
                    results.Add(Sum(Sum(Sum(Sum(inputs[1])))));
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        public static int Sum(int value)
        {
            return Enumerable.Range(1, value).Sum();
        }
    }
}