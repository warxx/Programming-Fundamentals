using System;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"\b(?<=\s)[a-zA-Z0-9][\w-.]+@([a-zA-Z-]+\.)+([a-z]+)\b";

            var regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
