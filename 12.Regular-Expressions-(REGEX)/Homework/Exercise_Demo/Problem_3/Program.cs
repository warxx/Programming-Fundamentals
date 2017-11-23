using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text.RegularExpressions;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var list = new List<string>();

            var args = Console.ReadLine().Split(' ');
            int m = int.Parse(args[0]);
            int n = int.Parse(args[1]);

            var regex = new Regex(@"(?<=\|<)(?<text>\w+)");

            var input = Console.ReadLine();

            var matches = regex.Matches(input).Cast<Match>().Select(a => a.Groups["text"].Value).ToArray();

            foreach (var text in matches)
            {
                if (text.Length >= m + n)
                {
                    list.Add(text.Substring(m, n));
                }
                else if (text.Length < m + n)
                {
                    list.Add(text.Remove(0, m));
                }
                else if (text.Length <= m)
                {
                    continue;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
