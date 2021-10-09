using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class LONGSEQ
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            var result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var number = Console.ReadLine();
                var countOne = 0;
                var countZero = 0;
                for(int j = 0; j < number.Length; j++)
                {
                    if(number[j] == '1')
                        countOne++;
                    else
                        countZero++;
                }
                result.Add(countOne == 1 || countZero == 1 ? "Yes": "No");
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}