using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            int output = Convert.ToInt32(hex, 16);
            Console.WriteLine(output);
        }
    }
}
