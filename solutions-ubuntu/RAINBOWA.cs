using System;
using System.Collections.Generic;
using System.Linq;

namespace solutions_ubuntu
{
    public class RAINBOWA
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());
            var result = new List<string>();
            for(int i = 0; i < testCases; i++)
            {
                var length = int.Parse(Console.ReadLine());
                var array = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                if(length % 2 != 0)
                {
                    var mid = (int)Math.Floor(length / 2.0);
                    if(array[mid] != 7)
                    {
                        result.Add("no");
                        break;
                    }
                    else
                    {
                        var insideLoop = false;
                        for(var j = 0; j < mid; j++)
                        {
                            if(array[j] != array[length - j - 1])
                            {
                                insideLoop = true;
                                result.Add("no");
                                break;
                            }
                        }
                        if(!insideLoop)
                            result.Add("yes");
                    }
                }
                else
                {
                    var mid = length / 2;
                    var insideLoop = false;
                    for(var j = 0; j < mid; j++)
                    {
                        if(array[j] != array[length - j - 1])
                        {
                            insideLoop = true;
                            result.Add("no");
                            break;
                        }
                    }
                    if(!insideLoop)
                        result.Add("yes");
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}