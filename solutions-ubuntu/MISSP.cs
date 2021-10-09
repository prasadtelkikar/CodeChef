using System;
using System.Linq;
using System.Collections.Generic;

namespace solutions_ubuntu
{
    public class MISSP
    {
        public static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine().Trim());
            for(int i = 0; i < testCases; i++)
            {
                var length = int.Parse(Console.ReadLine().Trim());
                List<int> dolls = new List<int>();
                for(int j = 0; j < length; j++)
                {
                    var dollNumber = int.Parse(Console.ReadLine().Trim());
                    if(dolls.Contains(dollNumber))
                        dolls.Remove(dollNumber);
                    else
                        dolls.Add(dollNumber);
                }
                foreach(var d in dolls)
                    Console.WriteLine(d);
            }
        }
    }
}