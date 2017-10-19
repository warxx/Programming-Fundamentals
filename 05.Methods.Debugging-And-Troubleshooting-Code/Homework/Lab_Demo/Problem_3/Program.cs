using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int endIndex)
        {
            for (int i = 1; i <= endIndex; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
