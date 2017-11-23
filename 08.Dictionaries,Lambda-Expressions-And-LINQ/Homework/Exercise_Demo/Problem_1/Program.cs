using System;
using System.Collections.Generic;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            string[] args = Console.ReadLine().Split(' ');
            var cmd = args[0];

            while (cmd != "END")
            {
                switch (cmd)
                {
                    case "A":
                        var aName = args[1];
                        var phone = args[2];

                        if (phonebook.ContainsKey(aName))
                        {
                            phonebook[aName] = phone;
                        }
                        else
                        {
                            phonebook.Add(aName, phone);
                        }
                        break;
                    case "S":
                        var sName = args[1];

                        if(phonebook.ContainsKey(sName))
                        {
                            Console.WriteLine($"{sName} -> {phonebook[sName]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {sName} does not exist.");
                        }

                        break;

                    case "ListAll":
                        foreach (var contact in phonebook)
                        {
                            Console.WriteLine($"{contact.Key} -> {contact.Value}");
                        }

                        break;
                }

                args = Console.ReadLine().Split(' ');
                cmd = args[0];
            }
        }
    }
}
