using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split(' ');

            Console.WriteLine(string.Join(" ", letters.Reverse()));
        }
    }
}
