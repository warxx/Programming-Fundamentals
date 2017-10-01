using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            int line = int.Parse(Console.ReadLine());
            decimal answer = 0;

            for (int i = 0; i < line; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                answer += currentNumber;
            }

            Console.WriteLine(answer);
        }
    }
}
