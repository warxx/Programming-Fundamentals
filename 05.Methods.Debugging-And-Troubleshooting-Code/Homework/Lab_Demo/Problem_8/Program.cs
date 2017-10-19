using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(firstValue), int.Parse(secondValue)));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(firstValue), char.Parse(secondValue)));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }

            return secondValue;
        }

        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }

            return secondValue;
        }

        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
            {
                return firstValue;
            }

            return secondValue;
        }
    }
}
