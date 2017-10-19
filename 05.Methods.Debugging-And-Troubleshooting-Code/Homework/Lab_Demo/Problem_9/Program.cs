using System;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            if (number.StartsWith("-"))
            {
                number = number.Substring(1, number.Length - 1);
            }

            int sumOfOddDigits = GetSumOfOddDigits(number);
            int sumOfEvenDigits = GetSumOfEvenDigits(number);

            Console.WriteLine(sumOfOddDigits * sumOfEvenDigits);
        }

        private static int GetSumOfOddDigits(string number)
        {
            int sum = 0;
            string numberr = number;

            while (numberr.Length > 0)
            {
                int curentDigit = int.Parse(numberr.Substring(numberr.Length - 1));

                if (curentDigit%2 != 0)
                {
                    sum += curentDigit;
                }

                numberr = numberr.Substring(0, numberr.Length - 1);
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(string number)
        {
            int sum = 0;
            string numberr = number;

            while (numberr.Length > 0)
            {
                int curentDigit = int.Parse(numberr.Substring(numberr.Length - 1));

                if (curentDigit % 2 == 0)
                {
                    sum += curentDigit;
                }

                numberr = numberr.Substring(0, numberr.Length - 1);
            }

            return sum;
        }
    }
}
