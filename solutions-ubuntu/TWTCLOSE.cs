using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class TWTCLOSE
    {
        public static void Main(string[] args){
            var inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            var tweets = new int[inputs[0]];
            var result = new List<int>(inputs[1]);
            for (int i = 0; i < inputs[1]; i++)
            {
                var clicks = Console.ReadLine().Trim().Split();
                var status = clicks[0];
                if(status == "CLOSEALL")
                    tweets = new int[inputs[0]];
                else{
                    var index = int.Parse(clicks[1]) - 1;
                    tweets[index] = tweets[index] == 0 ? 1 : 0;
                }
                var clickCount = tweets.Count(x => x == 1);
                result.Add(clickCount);
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}