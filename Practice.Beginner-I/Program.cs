using System;
using System.Collections.Generic;


namespace Practice.Beginner_I
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var input = Console.ReadLine();
                var flag = true;
                if (input.Length == 2)
                    flag = input[0] != input[1];
                else
                {
                    for (int j = 0; j < input.Length-2; j++)
                    {
                        if (input[j] != input[j + 2] || input[j] == input[j+1])
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                result.Add(flag ? "YES" : "NO");
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
