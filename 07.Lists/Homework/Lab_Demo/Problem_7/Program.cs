using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            var dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            foreach (var num in dict.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
