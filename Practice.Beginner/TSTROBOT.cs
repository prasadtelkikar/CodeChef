using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/TSTROBOT
    /// </summary>
    public class TSTROBOT
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int[] nx = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                string input = Console.ReadLine();

                int destination = FindDestination(input, nx[1]);
                results.Add(destination);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static int FindDestination(string inputString, int destination)
        {
            Dictionary<int, bool> visitedPlaces = new Dictionary<int, bool>();
            visitedPlaces.Add(destination, true);
            foreach (var ch in inputString)
            {
                if (ch == 'R')
                    destination++;
                else if (ch == 'L')
                    destination--;

                if (!visitedPlaces.ContainsKey(destination))
                    visitedPlaces.Add(destination, true);
            }
            return visitedPlaces.Count;
        }
    }
}