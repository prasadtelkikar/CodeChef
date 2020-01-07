using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.Beginner
{
    public class TabDetails
    {
        public TabDetails(int area, int price)
        {
            this.Area = area;
            this.Price = price;
        }

        public int Area { get; set; }

        public int Price { get; set; }
    }

    /// <summary>
    /// https://www.codechef.com/problems/TABLET
    /// </summary>
    public class TABLET
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<string>();

            for (int i = 0; i < testCases; i++)
            {
                var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int numOfTablet = inputs[0];
                int maxBudget = inputs[1];

                var tabDetailsObj = new List<TabDetails>();
                for (int j = 0; j < numOfTablet; j++)
                {
                    var tabInputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int area = tabInputs[0] * tabInputs[1];
                    tabDetailsObj.Add(new TabDetails(area, tabInputs[2]));
                }

                var tabDetails = tabDetailsObj.Where(x => x.Price <= maxBudget);
                string maxArea = (tabDetails.Count() > 0) ? tabDetails.Max(x => x.Area).ToString() : "no tablet";
                results.Add(maxArea);
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}