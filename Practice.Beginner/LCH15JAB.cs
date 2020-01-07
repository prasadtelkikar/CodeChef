using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/LCH15JAB
    /// </summary>
    public class LCH15JAB
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine();
                List<LetterDetails> letterDetails = new List<LetterDetails>();
                foreach (var ch in input.Distinct())
                    letterDetails.Add(new LetterDetails(ch, input.Count(x => x == ch), input.Length));

                var result = letterDetails.Where(x => x.LetterCount == x.Length).Count() > 0 ? "YES" : "NO";

                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }

    public class LetterDetails
    {
        public LetterDetails(char letter, int letterCount, int length)
        {
            this.Letter = letter;
            this.LetterCount = letterCount;
            this.Length = length - letterCount;
        }

        public int Length { get; set; }

        public char Letter { get; set; }

        public int LetterCount { get; set; }
    }
}