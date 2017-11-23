using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new [] {' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'}, StringSplitOptions.RemoveEmptyEntries).Select(e => e.ToLower());

            var words = new List<string>(input);
            var uniqueWords = words.Distinct();


            Console.WriteLine(string.Join(", ", uniqueWords.Where(e => e.Length < 5).OrderBy(e => e)));
        }
    }
}
