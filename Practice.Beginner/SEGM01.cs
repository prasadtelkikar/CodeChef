using System;

namespace Practice.Beginner
{
    public class SEGM01
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                result[i] = Console.ReadLine().Contains("1111") ? "YES" :"NO";
            }
            Console.WriteLine(result);
        }
    }
}
