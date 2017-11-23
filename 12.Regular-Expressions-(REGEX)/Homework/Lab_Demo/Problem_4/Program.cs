using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var regex = @"\b(\d{2})([\/.-])(?<month>[A-Z][a-z]{2})\2(\d{1,4})\b";

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                var day = match.Groups[1];
                var month = match.Groups["month"];
                var year = match.Groups[3];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
