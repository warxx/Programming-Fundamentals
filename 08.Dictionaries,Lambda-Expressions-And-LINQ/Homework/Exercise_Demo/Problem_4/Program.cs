using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, string>();

            var name = Console.ReadLine();

            while (name != "stop")
            {
                var email = Console.ReadLine();

                if (!persons.ContainsKey(name))
                {
                    persons.Add(name, email);
                }
                else
                {
                    persons[name] = email;
                }

                name = Console.ReadLine();
            }

            var filteredPersons = persons.Where(e => !e.Value.EndsWith("us") && !e.Value.EndsWith("uk")).ToDictionary(k => k.Key, v => v.Value);

            foreach (var person in filteredPersons)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
