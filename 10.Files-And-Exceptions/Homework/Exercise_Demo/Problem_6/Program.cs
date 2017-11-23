using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            var emails = new Dictionary<string, string>();

            var input = File.ReadAllLines(@"../../Input.txt");

            File.Delete(@"../../Output.txt");

            for (int i = 0; i < input.Length - 1; i+=2)
            {
                var name = input[i];
                var email = input[i + 1];

                emails[name] = email;
            }

            foreach (var email in emails.Where(e => !e.Value.EndsWith(".uk") && !e.Value.EndsWith(".us")))
            {
                File.AppendAllText(@"../../Output.txt", $"{email.Key} -> {email.Value}" + Environment.NewLine);
            }
        }
    }
}
