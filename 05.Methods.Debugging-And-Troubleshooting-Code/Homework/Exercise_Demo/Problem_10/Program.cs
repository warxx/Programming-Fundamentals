using System;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    Console.WriteLine($"{CalculateFace(side):F2}");
                    break;
                case "space":
                    Console.WriteLine($"{CalculateSpace(side):F2}");
                    break;
                case "volume":
                    Console.WriteLine($"{CalculateVolume(side):F2}");
                    break;
                case "area":
                    Console.WriteLine($"{CalculateArea(side):F2}");
                    break;
            }
        }

        private static double CalculateFace(double side)
        {
            return Math.Sqrt(2*Math.Pow(side, 2));
        }

        private static double CalculateSpace(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        private static double CalculateVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        private static double CalculateArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}
