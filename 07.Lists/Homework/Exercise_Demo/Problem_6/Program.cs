using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversedList = new List<int>();

            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                var numStr = nums[i].ToString().ToCharArray();
                Array.Reverse(numStr);
                var num = int.Parse(new string(numStr));

                reversedList.Add(num);
            }

            Console.WriteLine(reversedList.Sum());
        }
    }
}
