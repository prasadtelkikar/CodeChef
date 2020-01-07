using System;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL: https://www.codechef.com/problems/DECINC
    /// </summary>
    public class DECINC
    {
        public static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input % 4 == 0 ? ++input : --input);
        }
    }
}