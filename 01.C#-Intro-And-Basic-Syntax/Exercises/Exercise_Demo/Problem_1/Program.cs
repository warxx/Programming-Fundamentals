using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = int.Parse(Console.ReadLine()).ToString("D4");
            string secondNumber = int.Parse(Console.ReadLine()).ToString("D4");
            string thirdNumber = int.Parse(Console.ReadLine()).ToString("D4");
            string fourthNumber = int.Parse(Console.ReadLine()).ToString("D4");

            Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber}");
        }
    }
}
