using System;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/EXAM1
    /// </summary>
    public class EXAM1
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                int result = GetCorrectAnswerCount(length);
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }

        private static int GetCorrectAnswerCount(int length)
        {
            string correctAnswers = Console.ReadLine();
            string actualAnswers = Console.ReadLine();
            int points = 0;
            for (int i = 0; i < length; i++)
            {
                if (correctAnswers[i] == actualAnswers[i])
                    points++;
                else if (actualAnswers[i] == 'N')
                    continue;
                else
                    i++;
            }
            return points;
        }
    }
}