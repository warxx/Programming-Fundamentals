using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            string pattern = @"([^&=?]*)=([^&=]*)";
            string regex = @"(%20|\+)+";

            while (input != "END")
            {
                var matches = Regex.Matches(input, pattern);

                var queries = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    var args = match.Value.Split('=');

                    var field = Regex.Replace(args[0], regex, w => " ").Trim();
                    var value = Regex.Replace(args[1], regex, w => " ").Trim();


                    if (!queries.ContainsKey(field))
                    {
                        queries.Add(field, new List<string>());
                    }

                    queries[field].Add(value);
                }

                foreach (var query in queries)
                {
                    Console.Write($"{query.Key}=[" + string.Join(", ", query.Value) + "]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
