using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            RemoveNegatives(list);
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();

                Console.WriteLine(string.Join(" ", list));
            }
        }

        private static void RemoveNegatives(List<int> list)
        {
            list.RemoveAll(e => e < 0);
        }
    }
}
