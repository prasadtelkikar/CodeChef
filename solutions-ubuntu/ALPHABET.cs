using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class ALPHABET
    {
        public static void Main(string[] args)
        {
            var lattinLetters = Console.ReadLine();
            var inputs = int.Parse(Console.ReadLine().Trim());
            var output = new List<string>();
            for(int i = 0; i < inputs; i++)
            {
                var words = Console.ReadLine();
                var canRead = words.All(x => lattinLetters.Contains(x));
                output.Add(canRead ? "Yes" : "No");
            }
            Console.WriteLine(string.Join(Environment.NewLine, output));

        }
    }
}