
using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            string input = Console.ReadLine();

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                count++;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
