using System;
using System.Text.RegularExpressions;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            var result = string.Empty;

            var replacer = Console.ReadLine();

            var rgx = new Regex(@"^([a-zA-Z]+)[<\|\\]\w+[<\|\\]([a-zA-Z]+)$");

            var match = rgx.Match(replacer);

            var startKey = match.Groups[1].Value;
            var endKey = match.Groups[2].Value;

            var input = Console.ReadLine();

            var regex = new Regex($"{startKey}(.*?){endKey}");

            var matches = regex.Matches(input);

            foreach (Match match1 in matches)
            {
                result += match1.Groups[1].Value;
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
