using System;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    //Thanks to : https://youtu.be/N2e8wf1QcbM
    public class CATDOGS
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            var result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int catCount = inputs[0];
                int dogCount = inputs[1];
                int legCount = inputs[2];
                if(legCount % 4 != 0)
                {
                    result.Add("no");
                    continue;

                }
                else
                {
                    var animalCount = legCount / 4;
                    var catOnGround = animalCount - dogCount;
                    if(catOnGround < 0 || catOnGround > catCount)
                    {
                        result.Add("no");
                        continue;
                    }
                    if(catOnGround < catCount)
                    {
                        var catsOnDog = catCount - catOnGround;
                        if(catsOnDog < 0 || catsOnDog > (2 * dogCount))
                        {
                            result.Add("no");
                            continue;
                        }
                    }
                }
                result.Add("yes");
            }
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}