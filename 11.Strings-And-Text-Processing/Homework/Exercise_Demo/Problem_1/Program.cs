using System;
using System.Linq;
using System.Numerics;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var n = BigInteger.Parse(input[0]);
            var number = BigInteger.Parse(input[1]);

            string result = string.Empty;

            while (number > 0)
            {
                result += (number%n);

                number /= n;
            }

            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
