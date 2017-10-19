using System;
using System.Numerics;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            int zerosTrailing = 0;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }


            while (result % 10 == 0)
            {
                zerosTrailing++;
                result /= 10;
            }

            Console.WriteLine(zerosTrailing);
        }
    }
}
