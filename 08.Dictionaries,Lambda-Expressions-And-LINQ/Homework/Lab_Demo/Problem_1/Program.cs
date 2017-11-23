using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<double, int>();

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = 1;
                }
                else
                {
                    dict[nums[i]]++;
                }
            }

            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
