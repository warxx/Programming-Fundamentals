using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();

            var lists = Console.ReadLine().Split('|');

            for (int i = lists.Length - 1; i >= 0; i--)
            {
                result.AddRange(lists[i].Trim().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
