using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    public class CHN15A
    {
        public static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var minionDetails = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var charValue = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var result = charValue
                    .Select(x => x + minionDetails[1])
                    .Count(c => c % 7 == 0);

                results.Add(result);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}