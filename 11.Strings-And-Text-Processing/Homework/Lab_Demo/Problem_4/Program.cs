using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {',', '.', '?', '!', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var listOfPalindromes =new HashSet<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (IsPalindrome(input[i]))
                {
                    listOfPalindromes.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", listOfPalindromes.OrderBy(e => e)));
        }

        private static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
