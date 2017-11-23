using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matches = Regex.Matches(input, pattern);

            var matchedNumber = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", matchedNumber));
        }
    }
}
