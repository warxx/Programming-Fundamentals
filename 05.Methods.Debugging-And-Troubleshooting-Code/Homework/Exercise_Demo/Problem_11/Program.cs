using System;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    var triangleArea = CalculateTriangleArea(triangleSide, triangleHeight);
                    Console.WriteLine($"{triangleArea:F2}");
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    var squareArea = CalculateSquareArea(squareSide);
                    Console.WriteLine($"{squareArea:F2}");
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    var rectangleArea = CalculateRectangleArea(rectangleWidth, rectangleHeight);
                    Console.WriteLine($"{rectangleArea:F2}");
                    break;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    var circleArea = CalculateCircleArea(circleRadius);
                    Console.WriteLine($"{circleArea:F2}");
                    break;
            }
        }

        private static double CalculateCircleArea(double circleRadius)
        {
            return Math.PI*Math.Pow(circleRadius, 2);
        }

        private static double CalculateSquareArea(double squareSide)
        {
            return squareSide*squareSide;
        }

        private static double CalculateRectangleArea(double rectangleWidth, double rectangleHeight)
        {
            return rectangleHeight*rectangleWidth;
        }

        private static double CalculateTriangleArea(double triangleSide, double triangleHeight)
        {
            return triangleSide*triangleHeight/2;
        }


    }
}
