using System;
using System.Collections.Generic;
using System.Linq;

namespace DUCS
{
    public class DCC202
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var names = Console.ReadLine().Split(' ').ToList();
                Dictionary<string, int> dict = new Dictionary<string, int>();

                foreach (var name in names)
                {
                    if (dict.ContainsKey(name))
                        dict[name]++;
                    else
                        dict.Add(name, 1);
                }
                var maxCount = dict.Values.Max();
                var result = dict.Where(x => x.Value == maxCount).OrderBy(x => x.Key).First().Key;
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}