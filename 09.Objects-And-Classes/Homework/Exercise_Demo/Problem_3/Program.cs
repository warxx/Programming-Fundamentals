using System;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1Args = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var c2Args = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var center1 = new Center()
            {
                X = c1Args[0],
                Y = c1Args[1]
            };

            var center2 = new Center()
            {
                X = c2Args[0],
                Y = c2Args[1]
            };

            var c1 = new Circle()
            {
                Center = center1,
                Radius = c1Args[2]
            };

            var c2 = new Circle()
            {
                Center = center2,
                Radius = c2Args[2]
            };

            if (Intersect(c1, c2))
            {
                Console.WriteLine("Yes");                
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static double CalcDistance(Circle c1, Circle c2)
        {
            var distance = Math.Sqrt(Math.Pow(c2.Center.X - c1.Center.X, 2) + Math.Pow(c2.Center.Y - c1.Center.Y, 2));

            return distance;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            var distance = CalcDistance(c1, c2);

            if (distance <= c1.Radius + c2.Radius)
            {
                return true;
            }

            return false;
        }
    }

    public class Circle
    {
        public Center Center { get; set; }

        public double Radius { get; set; }

     }

    public class Center
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
