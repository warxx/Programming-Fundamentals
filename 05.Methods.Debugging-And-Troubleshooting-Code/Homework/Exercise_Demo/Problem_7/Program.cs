using System;
using System.Collections.Generic;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = new List<long>();

            long startNumber = long.Parse(Console.ReadLine());
            long endNumber = long.Parse(Console.ReadLine());

            for (long i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primes));
        }

        private static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
