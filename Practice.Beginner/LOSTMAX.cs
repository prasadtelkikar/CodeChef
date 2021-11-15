using System;
using System.Linq;

namespace Practice.Beginner
{
    public class LOSTMAX
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();
                input.Remove(input.Count - 1);
                result[i] = input.Max();
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
