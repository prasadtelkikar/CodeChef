using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOverflow_1._1
{
    public class LEXANALZ
    {
        public static void Main(string[] args)
        {
            int intItem = int.MinValue;
            float floatItem = float.MinValue;

            List<string> result = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                    break;
                var test = input.Split(' ');
                StringBuilder sb = new StringBuilder();
                foreach (var item in test)
                {
                    if (int.TryParse(item, out intItem))
                        sb.Append("int");
                    else if (float.TryParse(item, out floatItem))
                        sb.Append("float");
                    else
                        sb.Append("string");
                    sb.Append(" ");
                }
                result.Add(sb.ToString().Trim());
            }
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.ReadLine();
        }
    }
}