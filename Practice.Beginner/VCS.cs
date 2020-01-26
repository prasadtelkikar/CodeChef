using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    /// <summary>
    /// https://www.codechef.com/problems/VCS
    /// </summary>
    public class VCS
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<string> results = new List<string>();
            for (int i = 0; i < testCases; i++)
            {
                int[] size = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                var allFiles = Enumerable.Range(1, size[0]);

                var ignoredFiles = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); var trackedFiles =
                Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                var unionOfFiles = ignoredFiles.Union(trackedFiles); var intersectOfFiles = ignoredFiles.Intersect(trackedFiles);

                var untrackedUnignoreFiles = allFiles.Except(unionOfFiles).Count();
                var trackedAndIgnored = intersectOfFiles.Count();
                results.Add($"{trackedAndIgnored} {untrackedUnignoreFiles}");
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}