using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
        }
    }
}
