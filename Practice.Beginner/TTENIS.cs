using System;

namespace Practice.Beginner
{
    public class TTENIS
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                var win = 0;
                var lose = 0;
                var input = Console.ReadLine();
                foreach (var ch in input)
                {
                    if (ch == '1')
                        win++;
                    else
                        lose++;
                }
                result[i] = win > lose ? "WIN" : "LOSE";
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
