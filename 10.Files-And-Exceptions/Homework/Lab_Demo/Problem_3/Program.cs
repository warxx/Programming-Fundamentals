using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchedWords = new Dictionary<string, int>();

            var text 
                = File.ReadAllLines(@"..\..\..\Resources\03. Word Count\text.txt");

            var words 
                = File.ReadAllText(@"..\..\..\Resources\03. Word Count\words.txt")
                .Split(' ');

            foreach (var word in words)
            {
                matchedWords[word.ToLower()] = 0;
            }
            
            foreach (var line in text)
            {
                var wordsInLine = line.Split(new[] {',', ' ', '!', '?', '-', '.'}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < wordsInLine.Length; i++)
                {
                    var currentWord = wordsInLine[i].ToLower();

                    if (matchedWords.ContainsKey(currentWord))
                    {
                        matchedWords[currentWord]++;
                    }
                }
            }

            foreach (var word in matchedWords.OrderByDescending(e => e.Value))
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
                File.AppendAllText("../../Output.txt", $"{word.Key} -> {word.Value}" + Environment.NewLine);
            }
        }
    }
}
