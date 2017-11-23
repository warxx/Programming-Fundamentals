using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = new Dictionary<string, string>();

            var input = Console.ReadLine().Split(new []{',', ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                int totalHealth = 0;
                double totalDamage = 0;

                var matches = Regex.Matches(input[i], @"[^\d|\.|\+|\-|\*|\/]");

                foreach (Match match in matches)
                {
                    var num = (int)match.Value[0];

                    totalHealth += num;
                }

                var digMatches = Regex.Matches(input[i], @"[\-|\+]?[0-9]+\.?[0-9]*");

                foreach (Match digMatch in digMatches)
                {
                    var num = double.Parse(digMatch.Value);

                    totalDamage += num;
                }

                foreach (var symbol in input[i].Where(c => c == '*' || c == '/'))
                {
                    if (symbol == '*')
                    {
                        totalDamage *= 2;
                        continue;
                    }

                    if (symbol == '/')
                    {
                        totalDamage /= 2;
                    }
                }

                demons.Add(input[i], $"{input[i]} - {totalHealth} health, {totalDamage:F2} damage");
            }

            foreach (var demon in demons.OrderBy(d => d.Key))
            {
                Console.WriteLine(demon.Value);
            }
        }
    }
}
