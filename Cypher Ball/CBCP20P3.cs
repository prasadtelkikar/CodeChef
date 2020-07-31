using System;
using System.Collections.Generic;
using System.Linq;

namespace Cypher_Ball
{
    public class CBCP20P3
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            List<StringInfo> stringInfo = new List<StringInfo>();
            for (int i = 0; i < testCases; i++)
            {
                var name = Console.ReadLine().Trim();
                stringInfo.Add(new StringInfo(name));
            }
            var result = GetResult(stringInfo);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string GetResult(List<StringInfo> stringInfo)
        {
            foreach (var item in stringInfo)
            {
                var count = stringInfo.Where(x => x.Name != item.Name && item.FirstChar == x.LastChar);
                if (count.Count() == 0)
                    return "No";
            }
            return "Yes";
        }
    }

    public class StringInfo
    {
        public StringInfo(string name)
        {
            this.Name = name;
            this.FirstChar = this.Name.FirstOrDefault() == char.MinValue ? char.MaxValue : this.Name.FirstOrDefault();
            this.LastChar = this.Name.LastOrDefault() == char.MinValue ? char.MaxValue : this.Name.LastOrDefault();
        }

        public char FirstChar { get; set; }

        public char LastChar { get; set; }

        public string Name { get; set; }
    }
}