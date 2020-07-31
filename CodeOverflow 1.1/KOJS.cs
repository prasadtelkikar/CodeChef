using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeOverflow_1._1
{
    public class KOJS
    {
        public static void Main(string[] args)
        {
            var elements = new List<long>();
            int testCases = Convert.ToInt32(Console.ReadLine());
            var result = new List<string>();
            var tests = new List<List<long>>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                if (inputs[0] == 1)
                    elements.Add(inputs[1]);
                else if (inputs[0] == 2)
                    result.Add(elements.Contains(inputs[1]) ? "Yes" : "No");
                else
                {
                    elements.Sort();
                    var greater = elements.Where(x => x > inputs[1]);
                    if (greater.Count() == 0 || greater.First() == elements.Last())
                        result.Add("−1");
                    else
                        result.Add(greater.First().ToString());
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}