using System;
using System.Collections.Generic;
using System.Text;

namespace Compete.LTIME79
{
    public class GUESSNUM
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                StringBuilder sb = new StringBuilder();
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var number = Math.Ceiling(inputs[1] / (double)inputs[0]);
                List<NumberAndDivisors> numDiv = new List<NumberAndDivisors>();
                numDiv.Add(new NumberAndDivisors(0));
                for (int j = 1; j <= number; j++)
                {
                    var test = new NumberAndDivisors(j);
                    numDiv.Add(test);
                }

                foreach (var item in numDiv)
                {
                    foreach (var div in item.Divisors)
                    {
                        var m = inputs[0] * item.Number + div;
                        if (m == inputs[1])
                            sb.Append($"{item.Number} ");
                    }
                }
                string result = sb.ToString().Trim();
                if (string.IsNullOrEmpty(result))
                    results.Add("0");
                else
                    results.Add($"{result.Split(' ').Length}");
                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }

    public class NumberAndDivisors
    {
        public NumberAndDivisors(int number)
        {
            this.Number = number;
            this.Divisors = GetDivisors(Number);
        }

        public List<int> Divisors { get; set; }

        public int Number { get; set; }

        private List<int> GetDivisors(int number)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    result.Add(i);
            }
            return result;
        }
    }
}