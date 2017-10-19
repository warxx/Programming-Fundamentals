using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new Dictionary<int, int>();

            var arr = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!nums.ContainsKey(arr[i]))
                {
                    nums.Add(arr[i], 1);
                }
                else
                {
                    nums[arr[i]]++;
                }
            }

            var mostFrequentNum = nums.OrderByDescending(e => e.Value).FirstOrDefault();
            Console.WriteLine(mostFrequentNum.Key);
        }
    }
}
