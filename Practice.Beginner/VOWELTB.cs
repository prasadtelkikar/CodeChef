using System;
using System.Linq;
using System.Collections.Generic;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/VOWELTB
    /// </summary>
    public class BIT2A
    {
        public static void Main(string[] args)
        {
            var vowels = new List<char>() {'A', 'E', 'I', 'O', 'U'};
            var input = Console.Read();
            var isVowel = vowels.Any(x => x == input);
            Console.WriteLine(isVowel ? "Vowel" : "Consonant");
        }
    }
}
