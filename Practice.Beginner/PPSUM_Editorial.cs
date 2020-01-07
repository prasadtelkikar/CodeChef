using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/PPSUM_Editorial
    /// </summary>
    public class PPSUM_Editorial
    {
        public static int GetFirstNSum(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }

        public static int GetSum(int D, int N)
        {
            for (int i = 0; i < D; i++)
                N = GetFirstNSum(N);
            return N;
        }

        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var result = GetSum(inputs[0], inputs[1]);
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}