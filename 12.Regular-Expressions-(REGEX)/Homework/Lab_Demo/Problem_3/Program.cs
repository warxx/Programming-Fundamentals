using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, @"\b(?:0x)?[0-9A-F]+\b");

            var mathchedHexadecimals = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", mathchedHexadecimals));
        }
    }
}
