using System;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var firstWord = input[0];
            var secondWord = input[1];

            long result = 0;

            if (firstWord.Length < secondWord.Length)
            {
                result = Multiplier(firstWord, secondWord);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                result = Multiplier(secondWord, firstWord);
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    result += firstWord[i]*secondWord[i];
                }
            }

            Console.WriteLine(result);
        }

        private static long Multiplier(string smallerWord, string biggerWord)
        {
            long result = 0;

            for (int i = 0; i < smallerWord.Length; i++)
            {
                result += smallerWord[i] * biggerWord[i];
            }

            for (int i = smallerWord.Length; i < biggerWord.Length; i++)
            {
                result += biggerWord[i];
            }

            return result;
        }
    }
}
