using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeOverflow_1._1
{
    public class TRNSN
    {
        public static void Main(string[] args)
        {
            var length = 0;
            try
            { length = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { }
            var inputs = Console.ReadLine().Split(' ');
            var list = new List<long>();
            foreach (var item in inputs)
            {
                try
                {
                    long input = 0;
                    if (long.TryParse(item, out input))
                        list.Add(input);
                }
                catch (Exception ex) { }
            }
            var count = 0;
            list.Sort();
            for (int i = 0; i <= list.Count - 2; i++)
            {
                if (list[i] != list[i + 1])
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}