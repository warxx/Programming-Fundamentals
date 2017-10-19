using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 0; i < n; i++)
            {
                sum += Fibonacci(i);
            }

            Console.WriteLine(sum);
        }

        private static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
