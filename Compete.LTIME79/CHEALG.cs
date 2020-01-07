using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compete.LTIME79
{
    public class CHEALG
    {
        public static int FindConsecutiveLetters(string input, char letter)
        {
            int count = 0;
            foreach (var item in input)
            {
                if (item == letter)
                    count++;
                else
                    break;
            }
            return count;
        }

        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                int currentIndex = 0;
                var sb = new StringBuilder();

                while (true)
                {
                    if (currentIndex >= input.Length)
                        break;

                    string currentString = input.Substring(currentIndex);
                    var currentLetter = currentString.First();
                    var count = FindConsecutiveLetters(currentString, currentLetter);
                    currentIndex += count;
                    sb.Append($"{currentLetter}{count}");
                }
                var result = input.Length > sb.ToString().Length ? "YES" : "NO";
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}