using System;

namespace solutions_ubuntu
{
    public class AREAPERI
    {
        public static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var breadth = int.Parse(Console.ReadLine());

            var area = length * breadth;
            var perimeter = 2 * (length + breadth);

            var result = string.Empty;
            if(area > perimeter)
                result = $"Area{Environment.NewLine}{area}";
            else if(perimeter > area)
                result = $"Peri{Environment.NewLine}{perimeter}";
            else
                result = $"Eq{Environment.NewLine}{area}";
            Console.WriteLine(result);
            
        }
    }
}