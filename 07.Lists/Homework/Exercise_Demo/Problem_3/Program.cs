using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            nums = nums.Take(args[0]).ToList();
            for (int i = 0; i < args[1]; i++)
            {
                nums.Remove(nums[0]);
            }

            if (nums.Contains(args[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
