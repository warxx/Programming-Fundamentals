using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var checker = new Dictionary<int, string>();
            var events = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();

            while (input != "Time for Code")
            {
                if (!Regex.IsMatch(input, @"([0-9]+)\s+(#[a-zA-Z0-9\'\-]+)\s*(@[a-zA-Z0-9\'\- ]+)*"))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var eventArgs = input.Split(new[] {' ', '@', '#'}, StringSplitOptions.RemoveEmptyEntries);

                var id = int.Parse(eventArgs[0]);
                var eventName = eventArgs[1];

                if (!checker.ContainsKey(id))
                {
                    checker.Add(id, eventName);
                    events.Add(eventName, new List<string>());

                    for (int i = 2; i < eventArgs.Length; i++)
                    {
                        if (events[eventName].Contains(eventArgs[i]))
                        {
                            continue;
                        }

                        events[eventName].Add(eventArgs[i]);
                    }
                }
                else
                {
                    if (checker[id] == eventName)
                    {
                        for (int i = 2; i < eventArgs.Length; i++)
                        {
                            if (events[eventName].Contains(eventArgs[i]))
                            {
                                continue;
                            }

                            events[eventName].Add(eventArgs[i]);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var @event in events.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                Console.WriteLine($"{@event.Key} - {@event.Value.Count}");
                foreach (var participant in @event.Value.OrderBy(p => p))
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}
