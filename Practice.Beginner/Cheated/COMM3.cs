using System;
using System.Collections.Generic;

namespace Practice.Beginner.Cheated
{
    /// <summary>
    /// https://www.codechef.com/problems/COMM3
    /// </summary>
    public class COMM3
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> result = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                var range = Convert.ToInt32(Console.ReadLine());
                var chefCoordinate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var inRange = AreChefsInRange(range, chefCoordinate[0], chefCoordinate[1]);
                result.Add(inRange);
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }

        private static string AreChefsInRange(int range, int x1, int y1)
        {
            var subChefOneCoordinates = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var subChefTwoCoordinates = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            var resultOne = ((x1 - subChefOneCoordinates[0]) * (x1 - subChefOneCoordinates[0])) + ((y1 - subChefOneCoordinates[1]) * (y1 - subChefOneCoordinates[1]));

            var resultTwo = ((x1 - subChefTwoCoordinates[0]) * (x1 - subChefTwoCoordinates[0])) + ((y1 - subChefTwoCoordinates[1]) * (y1 - subChefTwoCoordinates[1]));

            var resultThree = ((subChefOneCoordinates[0] - subChefTwoCoordinates[0]) * (subChefOneCoordinates[0] - subChefTwoCoordinates[0])) + ((subChefOneCoordinates[1] - subChefTwoCoordinates[1]) * (subChefOneCoordinates[1] - subChefTwoCoordinates[1]));

            var result = range * range;
            if ((resultOne <= result && resultTwo <= result) || (resultTwo <= result && resultThree <= result) || (resultThree <= result && resultOne <= result))
                return "yes";

            return "no";
        }
    }
}