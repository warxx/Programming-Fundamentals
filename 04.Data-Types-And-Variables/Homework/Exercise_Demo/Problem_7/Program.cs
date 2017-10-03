using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {num1}\nb = {num2}");

            int temporaryNum = num1;
            num1 = num2;
            num2 = temporaryNum;

            Console.WriteLine($"After:\na = {num1}\nb = {num2}");
        }
    }
}
