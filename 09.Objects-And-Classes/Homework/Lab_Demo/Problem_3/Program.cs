﻿using System;
using System.Numerics;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
    }
}
