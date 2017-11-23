using System;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1Args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var p2Args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var x1 = p1Args[0];
            var y1 = p1Args[1];
            var x2 = p2Args[0];
            var y2 = p2Args[1];

            var firstPoint = new Point()
            {
                x = x1,
                y = y1
            };

            var secondPoint = new Point()
            {
                x = x2,
                y = y2
            };

            Console.WriteLine($"{CalcDistance(firstPoint, secondPoint):F3}");
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.x - p2.x;
            var b = p1.y - p2.y;

            return Math.Sqrt(a*a + b*b);
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
