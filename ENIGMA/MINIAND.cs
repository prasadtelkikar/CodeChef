using System;
using System.Collections.Generic;

namespace ENIGMA
{
    /// <summary>
    /// Failed attempt
    /// </summary>
    public class MINIAND
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int inputs = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < inputs; j++)
                {
                    var indexes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    var andOperation = FindResult(array, indexes);
                    string result = andOperation % 2 == 0 ? "EVEN" : "ODD";
                    results.Add(result);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static long FindResult(int[] inputs, int[] indexes)
        {
            int startIndex = indexes[0] - 1;
            int endIndex = indexes[1] - 1;
            var result = (long)inputs[startIndex];
            for (int i = indexes[0]; i <= endIndex; i++)
            {
                result &= inputs[i];
            }
            return result;
        }
    }
}