using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(a, b, c));
        }

        private static int GetMax(int a, int b, int c)
        {
            int biggerNum = Math.Max(a, b);
            return Math.Max(biggerNum, c);
        }
    }
}
