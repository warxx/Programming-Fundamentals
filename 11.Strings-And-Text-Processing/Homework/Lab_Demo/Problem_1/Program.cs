using System;
using System.Runtime.InteropServices;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine();

            Console.WriteLine(Reverse(str));
        }

        private static string Reverse(string str)
        {
            string reversed = String.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            return reversed;
        }
    }
}
