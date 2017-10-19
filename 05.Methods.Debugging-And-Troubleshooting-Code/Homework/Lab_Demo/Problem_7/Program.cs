using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, pow));
        }

        static double RaiseToPower(double number, int pow)
        {
            return Math.Pow(number, pow);
        }
    }
}
