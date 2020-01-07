using System;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/AMR15A
    /// </summary>
    public class AMR15A
    {
        public static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());

            var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int evenWeapons = inputs.Count(x => x % 2 == 0);
            int oddWeapons = inputs.Count(x => x % 2 != 0);

            Console.WriteLine(evenWeapons > oddWeapons ? "READY FOR BATTLE" : "NOT READY");
            Console.ReadLine();
        }
    }
}