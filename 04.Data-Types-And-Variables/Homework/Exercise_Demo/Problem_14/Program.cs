using System;

namespace Problem_14
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var hex = number.ToString("X");
            var binary = Convert.ToString(number, 2);

            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
