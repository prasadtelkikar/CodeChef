using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class CATDOGS
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            var result = new List<string>();
            for(var i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                var legCount = inputs[2];
                var dogLegCount = inputs[1];
                var inputCatLegCount = inputs[0];
                var actualLegCount = dogLegCount * 4 + inputCatLegCount * 4;
                if(actualLegCount <= legCount)
                    result.Add("yes");
                else
                {
                    //Failed attempt of CATSDOGS

                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}