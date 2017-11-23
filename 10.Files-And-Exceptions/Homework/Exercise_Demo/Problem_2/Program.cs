using System;
using System.Collections.Generic;
using System.IO;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputList = new List<string>();

            var englishAlphabet = new[]
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

          //  File.Delete(@"../../Output.txt");

            var text = File.ReadAllText(@"../../Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                var index = Array.IndexOf(englishAlphabet, letter);

                outputList.Add($"{letter} -> {index}");
            }

            File.WriteAllLines(@"../../Output.txt", outputList);

            return;
        }
    }
}
