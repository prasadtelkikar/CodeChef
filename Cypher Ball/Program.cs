using System;
using System.Collections.Generic;
using System.Linq;

namespace Cypher_Ball
{
    public class Program
    {
        public static int inputStatic = 0;
        public static IList<int> result;

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int resultCount = 0;
            for (int i = 0; i <= input; i++)
            {
                result = new List<int>();

                char[] arr = i.ToString().ToCharArray();
                GetPer(arr);

                var test = result.Count(x => x >= i);
                if (i != 0 && test == result.Count())
                    resultCount++;
            }
            Console.WriteLine(resultCount);
            Console.ReadLine();
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                var test = Convert.ToInt32(new string(list));
                result.Add(test);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }
    }
}