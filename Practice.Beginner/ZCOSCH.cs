using System;

namespace Practice.Beginner
{
    public class ZCOSCH
    {
        public static void Main(string[] args)
        {
            long rank = long.Parse(Console.ReadLine());
            if (1 <= rank && rank <= 50)
                Console.WriteLine(100);
            else if (51 <= rank && rank <= 100)
                Console.WriteLine(50);
            else
                Console.WriteLine(0);
        }
    }
}