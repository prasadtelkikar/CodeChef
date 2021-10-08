using System;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class MISSP
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            List<string> result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                HashSet<int> uniqueDolls = new HashSet<int>();
                var noOfDolls = int.Parse(Console.ReadLine().Trim());
                for(int j = 0; j < noOfDolls; j++){
                    var dollNumber = int.Parse(Console.ReadLine().Trim());
                    uniqueDolls.Add(dollNumber);
                }
                result.Add(string.Join(Environment.NewLine, uniqueDolls));
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}