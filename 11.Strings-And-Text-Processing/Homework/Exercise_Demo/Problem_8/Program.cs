using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double finalResult = 0;

            var input = Console.ReadLine().Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                double currentResult = 0;

                var word = input[i];

                var letterBefore = word[0];
                var letterAfter = word[word.Length - 1];

                word = word.Remove(0, 1);
                word = word.Remove(word.Length - 1, 1);

                double digit = double.Parse(word);

                if (char.IsLower(letterBefore))
                {
                    var letterPosition = letterBefore - 96;

                    currentResult += digit*letterPosition;
                }
                else
                {
                    letterBefore = char.ToLower(letterBefore);

                    var letterPosition = letterBefore - 96;
                    currentResult += digit/letterPosition;
                }

                if (char.IsLower(letterAfter))
                {
                    var letterPosition = letterAfter - 96;

                    currentResult += letterPosition;
                }
                else
                {
                    letterAfter = char.ToLower(letterAfter);

                    var letterPosition = letterAfter - 96;
                    currentResult -= letterPosition;
                }

                finalResult += currentResult;
            }

            Console.WriteLine($"{finalResult:F2}");
        }
    }
}
