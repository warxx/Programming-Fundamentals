using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] is_Prime = new bool[n + 1];
            for (long i = 0; i < is_Prime.Length; i++)
            {
                is_Prime[i] = true;
            }

            is_Prime[0] = false;
            is_Prime[1] = false;

            for (long i = 2; i < is_Prime.Length; i++)
            {
                if (is_Prime[i])
                {
                    for (long j = i + i; j < is_Prime.Length; j+=i)
                    {
                        is_Prime[j] = false;
                    }
                }
            }

            var primes = new List<long>();

            for (long i = 0; i < is_Prime.Length; i++)
            {
                if (is_Prime[i])
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", primes));
        }
    }
}
