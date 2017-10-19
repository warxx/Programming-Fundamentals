using System;
using System.Text;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    sb.AppendLine($"{i}");
                }
            }

            Console.WriteLine(sb);
        }

        public static bool IsPalindrome(int number)
        {
           // int num1 = number;
            string numStr = number.ToString();

            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] != numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool SumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number%10;
                number /= 10;
            }

            return sum%7 == 0;
        }

        public static bool ContainsEvenDigit(int number)
        {
            int digit;

            while (number > 0)
            {
                digit = number % 10;

                if (digit%2 == 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
