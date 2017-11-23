using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}
