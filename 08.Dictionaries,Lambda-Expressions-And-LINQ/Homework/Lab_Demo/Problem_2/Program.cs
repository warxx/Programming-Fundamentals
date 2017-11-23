using System;
using System.Collections.Generic;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            var words = Console.ReadLine().ToLower().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
                else
                {
                    dict[words[i]] = 1;
                }
            }

            var result = new List<string>();

            foreach (var word in dict)
            {
                if (word.Value%2 != 0)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
