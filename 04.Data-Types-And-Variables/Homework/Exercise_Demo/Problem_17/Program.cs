using System;
using System.Collections.Generic;

namespace Problem_17
{
    class Program
    {
        static void Main()
        {
            var chars = new List<char>();

            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                chars.Add(Convert.ToChar(i));
            }

            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
