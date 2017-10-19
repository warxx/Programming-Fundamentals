using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height));
        }

        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
