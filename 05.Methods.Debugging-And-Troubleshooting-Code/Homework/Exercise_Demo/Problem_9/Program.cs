
using System;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double d1 = CalculateDis(x1, y1);
            double d2 = CalculateDis(x2, y2);
            double d3 = CalculateDis(x3, y3);
            double d4 = CalculateDis(x4, y4);

            var firstDistance = CalculateDistance(x1, y1, x2, y2);
            var secondDistance = CalculateDistance(x3, y3, x4, y4);

            if (firstDistance >= secondDistance)
            {
                if (d1 > d2)
                {
                    Console.WriteLine($"({x2},{y2})({x1},{y1})");
                }
                else
                {
                    Console.WriteLine($"({x1},{y1})({x2},{y2})");
                }
            }
            else
            {
                if (d3 > d4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }
        }

        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        }

        private static double CalculateDis(double x, double y)
        {
            return Math.Sqrt(x*x + y*y);
        }
    }
}
