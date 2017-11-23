using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var input = Console.ReadLine();

            var regex = new Regex($@"\b[^.?!]*\b{keyWord}[^.?!]*");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
