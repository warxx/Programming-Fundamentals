using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digits = i;
                int sum = 0;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
