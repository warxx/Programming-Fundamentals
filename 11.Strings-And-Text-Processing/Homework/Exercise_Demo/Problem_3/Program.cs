using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var codes = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                codes.Add($"\\u00{(int)input[i]:x}");
            }

            Console.WriteLine(string.Join("", codes));
        }
    }
}
