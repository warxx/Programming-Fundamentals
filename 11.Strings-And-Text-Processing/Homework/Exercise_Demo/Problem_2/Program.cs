using System;
using System.Numerics;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var n = int.Parse(input[0]);
            var number = input[1];
            int counter = 0;
            BigInteger result = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                var digit = int.Parse(number[i].ToString());
                result += (digit*BigInteger.Pow(n, counter));
                counter++;
            }

            Console.WriteLine(result);
        }
    }
}
