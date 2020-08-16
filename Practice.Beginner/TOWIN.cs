using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    public class TOWIN
    {
        public static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var arrayCount = int.Parse(Console.ReadLine());
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse).OrderByDescending(x => x).ToArray();

                string result = FindResult(array, arrayCount);
                results.Add(result);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }

        private static string FindResult(long[] array, int arrayCount)
        {
            var p1 = array[0];
            var p2 = 0L;
            for (int i = 1; i < arrayCount; i++)
            {
                if (i == 1 || i == 2 || i % 2 == 0)
                    p2 += array[i];
                else
                    p1 += array[i];
            }
            if (p1 > p2)
                return "first";
            else if (p1 < p2)
                return "second";
            else
                return "draw";
        }
    }
}