using System;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(ReverseWord(word));
        }

        private static string ReverseWord(string word)
        {
            var charArr = word.ToCharArray();
            Array.Reverse(charArr);

            return new string(charArr);
        }
    }
}
