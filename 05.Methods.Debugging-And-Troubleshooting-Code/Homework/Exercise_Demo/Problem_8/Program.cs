using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double d1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double d2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (d1 > d2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
