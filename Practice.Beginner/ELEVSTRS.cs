using System;

namespace Practice.Beginner
{
    /// <summary>
    /// Formula of Velocity = Displacement / Time
    /// </summary>
    public class ELEVSTRS
    {
        public static void Main(string[] args)
        {
            var testCases = Convert.ToInt32(Console.ReadLine());
            var result = new string[testCases];
            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

                var t1 = (Math.Sqrt(2) * inputs[0]) / inputs[1];
                var t2 = (2 * inputs[0]) / inputs[2];
                result[i] = t1 < t2 ? "Stairs" : "Elevator";
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
