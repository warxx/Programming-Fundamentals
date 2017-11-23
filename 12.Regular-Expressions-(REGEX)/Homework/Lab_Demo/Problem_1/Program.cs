using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            var listOfNames = new List<string>();

            var input = Console.ReadLine();

            Regex regex = new Regex(@"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");

            foreach (Match match in regex.Matches(input))
            {
                listOfNames.Add(match.Value);
            }

            Console.WriteLine(string.Join(" ", listOfNames));
        }
    }
}
