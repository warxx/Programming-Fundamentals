using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secondNumber; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
