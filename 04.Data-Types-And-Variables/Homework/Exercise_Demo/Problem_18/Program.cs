using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fitTypes = new List<string>();

            BigInteger number = BigInteger.Parse(Console.ReadLine());


            if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            {
                fitTypes.Add("sbyte");
            }

            if (number >= byte.MinValue && number <= byte.MaxValue)
            {
                fitTypes.Add("byte");
            }

            if (number >= short.MinValue && number <= short.MaxValue)
            {
                fitTypes.Add("short");
            }

            if (number >= ushort.MinValue && number <= ushort.MaxValue)
            {
                fitTypes.Add("ushort");
            }

            if (number >= int.MinValue && number <= int.MaxValue)
            {
                fitTypes.Add("int");
            }

            if (number >= uint.MinValue && number <= uint.MaxValue)
            {
                fitTypes.Add("uint");
            }

            if (number >= long.MinValue && number <= long.MaxValue)
            {
                fitTypes.Add("long");
            }

            if (fitTypes.Count == 0)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{number} can fit in:");
                foreach (var type in fitTypes)
                {
                    Console.WriteLine($"* {type}");
                }
            }
        }
    }
}
