using System;
using System.Collections.Generic;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] {' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']'}, StringSplitOptions.RemoveEmptyEntries);

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (IsUpper(words[i]))
                {
                    upperCaseWords.Add(words[i]);
                }
                else if (IsLower(words[i]))
                {
                    lowerCaseWords.Add(words[i]);
                }
                else
                {
                    mixedCaseWords.Add(words[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseWords));
        }

        private static bool IsLower(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]) || !char.IsLetter(word[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsUpper(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]) || !char.IsLetter(word[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
