using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    public class MovieDetails
    {
        public MovieDetails(int LR, int rating, int index)
        {
            this.MultiplyLR = LR;
            this.Rating = rating;
            this.Index = index;
        }

        public int Index { get; set; }

        public int MultiplyLR { get; set; }

        public int Rating { get; set; }
    }

    /// <summary>
    /// https://www.codechef.com/problems/MOVIEWKN
    /// </summary>
    public class MOVIEWKN
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var movieLengths = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var movieRatings = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var movieDetails = new List<MovieDetails>();
                for (int j = 0; j < length; j++)
                {
                    var lr = movieLengths[j] * movieRatings[j];
                    movieDetails.Add(new MovieDetails(lr, movieRatings[j], j));
                }
                var result = movieDetails.OrderByDescending(x => x.MultiplyLR)
                    .ThenByDescending(x => x.Rating)
                    .ThenBy(x => x.Index)
                    .Select(x => x.Index)
                    .FirstOrDefault();

                results.Add(result + 1);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}