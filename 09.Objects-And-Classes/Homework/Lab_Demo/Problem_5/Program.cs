using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Point[] points = new Point[lines];

            for (int i = 0; i < lines; i++)
            {
                var pointArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var x = pointArgs[0];
                var y = pointArgs[1];

                var point = new Point()
                {
                    x = x,
                    y = y,
                };

                points[i] = point;
            }

            var closestPoints = FindClosestPoints(points);

            Console.WriteLine($"{CalcDistance(closestPoints[0], closestPoints[1]):F3}");
            Console.WriteLine($"({closestPoints[0].x}, {closestPoints[0].y})");
            Console.WriteLine($"({closestPoints[1].x}, {closestPoints[1].y})");
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.x - p2.x;
            var b = p1.y - p2.y;

            return Math.Sqrt(a * a + b * b);
        }

        public static Point[] FindClosestPoints(Point[] points)
        {
            var closestPoints = new Point[2];
            var closestDistances = double.MaxValue;


            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {

                    var distance = CalcDistance(points[i], points[j]);
                    if (distance < closestDistances)
                    {
                        closestDistances = distance;
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            return closestPoints;
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
