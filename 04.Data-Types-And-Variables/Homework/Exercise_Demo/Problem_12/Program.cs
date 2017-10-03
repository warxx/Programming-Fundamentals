using System;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double perimeter = (2*height) + (2*width);
            double area = height*width;
            double diagonal = Math.Sqrt(Math.Pow(height, 2) + (Math.Pow(width, 2)));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
