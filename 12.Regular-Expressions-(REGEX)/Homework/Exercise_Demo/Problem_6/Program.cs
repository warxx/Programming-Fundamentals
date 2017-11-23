using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            var usernames = new List<string>();

            var input = Console.ReadLine()
                .Split(new[] {' ', '/', '\\', '(', ')'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"^[a-zA-Z]\w{2,24}$";

            for (int i = 0; i < input.Length; i++)
            {
                var username = input[i];

                if (Regex.IsMatch(username, pattern))
                {
                    var match = Regex.Match(username, pattern);

                    usernames.Add(match.Value);
                }
            }

            int biggestLength = 0;
            string[] biggestUsernames = new string[2];

            for (int i = 1; i < usernames.ToArray().Length; i++)
            {
                if (biggestLength < usernames[i - 1].Length + usernames[i].Length)
                {
                    biggestLength = usernames[i - 1].Length + usernames[i].Length;
                    biggestUsernames[0] = usernames[i - 1];
                    biggestUsernames[1] = usernames[i];
                }
            }

            Console.WriteLine(biggestUsernames[0]);
            Console.WriteLine(biggestUsernames[1]);
        }
    }
}
