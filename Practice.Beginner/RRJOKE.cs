using System;

namespace Practice.Beginner
{
    public class RRJOKE
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                for (var j = 0; j < length; j++)
                {
                    Console.ReadLine();
                    result = result ^ i;
                }
                Console.WriteLine(result);
            }
        }
    }
}