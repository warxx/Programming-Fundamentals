using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            Console.WriteLine(PrintLastDigit(number));
        }

        private static string PrintLastDigit(string number)
        {
            switch (number[number.Length - 1])
            {
                case '0':
                    return "zero";
                case '1':
                    return "one";
                case '2':
                    return "two";
                case '3':
                    return "three";
                case '4':
                    return "four";
                case '5':
                    return "five";
                case '6':
                    return "six";
                case '7':
                    return "seven";
                case '8':
                    return "eigth";
                case '9':
                    return "nine";
                default:
                    return "fuck";
            }
        }
    }
}
