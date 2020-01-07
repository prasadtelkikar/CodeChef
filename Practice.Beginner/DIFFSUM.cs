using System;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/DIFFSUM
    /// </summary>
    public class DIFFSUM
    {
        public static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 > n2 ? n1 - n2 : n1 + n2);
            Console.ReadKey();
        }
    }
}