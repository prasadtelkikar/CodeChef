using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/COPS
    /// </summary>
    public class COPS
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var maxHouses = inputs[1] * inputs[2];
                var copsHouse = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                Array.Sort(copsHouse);

                var startingIndex = copsHouse[0] - maxHouses;
                var result = (startingIndex < 0) ? 0 : startingIndex;
                for (int j = 1; j < copsHouse.Length; j++)
                {
                }
            }
        }
    }
}