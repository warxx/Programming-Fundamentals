using System;

namespace Problem_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            bool isEqual = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(isEqual);
        }
    }
}
