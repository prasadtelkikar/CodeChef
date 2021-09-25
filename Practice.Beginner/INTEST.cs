using System;

namespace Practice.Beginner
{
    public class INTEST
    {
        public static void Main(string[] args)
        {
            var inputStr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var n = inputStr[0];
            var k = inputStr[1];

            var count = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % k == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
