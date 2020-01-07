using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FRK
    /// </summary>
    public class FRK
    {
        public static void Main(string[] args)
        {
            List<string> nickNames = new List<string>() { "ch", "he", "ef", "che", "hef", "chef" };
            int testCases = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < testCases; i++)
            {
                var name = Console.ReadLine();
                var isNicknameExists = nickNames.Any(x => name.Contains(x));
                if (isNicknameExists)
                    counter++;
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}