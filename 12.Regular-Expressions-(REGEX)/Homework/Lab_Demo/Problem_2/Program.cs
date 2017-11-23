using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"\+359( |-)2\1{1}([0-9]{3})\1([0-9]{4})\b";

            var regex = new Regex(pattern);

            var mathes = regex.Matches(input);

            var matchedPhones = mathes.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
