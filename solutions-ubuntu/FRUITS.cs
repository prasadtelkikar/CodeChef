using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class FRUITS
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            List<int> result = new List<int>();

            for (int i = 0; i < testCases; i++)
            {
                var fruitCount = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                var min = Math.Min(fruitCount[0], fruitCount[1]);
                var max = Math.Max(fruitCount[0], fruitCount[1]);

                var newFruits = min + fruitCount[2];
                if(newFruits >= max)
                    result.Add(0);
                else
                    result.Add(max - newFruits);
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}