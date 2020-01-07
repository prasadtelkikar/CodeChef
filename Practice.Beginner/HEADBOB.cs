using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/HEADBOB
    /// </summary>
    public class HEADBOB
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                string gesture = Console.ReadLine();
                if (gesture.Contains('Y'))
                    result.Add("NOT INDIAN");
                else if (gesture.Contains('I'))
                    result.Add("INDIAN");
                else
                    result.Add("NOT SURE");
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}