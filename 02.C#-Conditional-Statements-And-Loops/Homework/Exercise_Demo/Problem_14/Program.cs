using System;
using System.Collections.Generic;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            var strings = new List<string>();

            for (int i = firstChar; i <= secondChar; i++)
            {
                for (int j = firstChar; j <= secondChar; j++)
                {
                    for (int k = firstChar; k <= secondChar; k++)
                    {
                        string str = $"{(char)i}{(char)j}{(char)k}";
                        if (!str.Contains(thirdChar.ToString()))
                        {
                            strings.Add(str);
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
