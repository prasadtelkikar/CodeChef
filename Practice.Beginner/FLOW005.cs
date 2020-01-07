using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// Problem URL:https://www.codechef.com/problems/FLOW005
    /// </summary>
    public class FLOW005
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            List<int> notes = new List<int>() { 100, 50, 10, 5, 2, 1 };
            for (int i = 0; i < testCases; i++)
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while (amount != 0)
                {
                    for (int j = 0; j < notes.Count(); j++)
                    {
                        count += Convert.ToInt32(amount / notes[j]);
                        amount = amount % notes[j];
                        if (amount == 0)
                            break;
                    }
                }
                results.Add(count);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadKey();
        }
    }
}