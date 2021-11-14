using System;

namespace Practice.Beginner
{
    public class SLOOP
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var result = new int[testCases];
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                result[i] = inputs[0] / inputs[1];
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
