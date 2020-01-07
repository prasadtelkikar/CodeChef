using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compete.LTIME79
{
    public class Box
    {
        public Box(int capacity) { this.Capacity = capacity; }

        public int Capacity { get; set; }

        public bool GetIsFull() { return 0 == this.Capacity; }
    }

    public class STUPMACH
    {
        public static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            var results = new List<int>();
            for (int i = 0; i < testCases; i++)
            {
                int numberOfBoxes = Convert.ToInt32(Console.ReadLine());
                var boxes = new List<Box>(numberOfBoxes);
                var inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                foreach (var input in inputs)
                {
                    var box = new Box(input);
                    boxes.Add(box);
                }
                int count = 0;
                bool iterator = true;

                var inputsDesc = inputs.OrderByDescending(z => z);
                while (iterator)
                {
                    foreach (var item in boxes)
                    {
                        if (item.GetIsFull())
                            continue;
                        item.Capacity++;
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
            Console.ReadLine();
        }
    }
}