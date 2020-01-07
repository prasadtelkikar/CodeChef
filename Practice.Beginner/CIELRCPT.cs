using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/CIELRCPT
    /// </summary>
    public class CIELRCPT
    {
        public static void Main(string[] args)
        {
            var list = new List<int>() { 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                while (true)
                {
                    if (input == 0)
                        break;

                    var price = list.First(x => input >= x);
                    input -= price;
                    result++;
                }
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}