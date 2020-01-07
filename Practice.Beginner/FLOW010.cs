using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/FLOW010
    /// </summary>
    public class FLOW010
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> shipClass = new List<string>() { "BattleShip", "Cruiser", "Destroyer", "Frigate" };
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int index = 0;
                string classId = Console.ReadLine().ToLower();
                if (classId == "b")
                    index = 0;
                else if (classId == "c")
                    index = 1;
                else if (classId == "d")
                    index = 2;
                else
                    index = 3;
                results.Add(shipClass[index]);
            }

            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}