using System;
using System.Collections.Generic;

namespace ENIGMA
{
    /// <summary>
    /// Failed attempt
    /// </summary>
    public class VILLINE
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            var leftToY = 0;
            var rightToY = 0;
            var straightLine = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var yIntercept = straightLine[1];
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                //Right
                if (inputs[1] > yIntercept)
                    rightToY += inputs[2];
                else
                    leftToY += inputs[2];
            }
            var result = Math.Max(rightToY, leftToY);
            results.Add(result);
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}