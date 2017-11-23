using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var args = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var bomb = args[0];
            var power = args[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    for (int j = 1; j <= power; j++)
                    {
                        if (i - j >= 0)
                        {
                            nums[i - j] = 0;
                        }

                        if (i + j < nums.Count)
                        {
                            nums[i + j] = 0;
                        }
                    }

                    nums[i] = 0;
                }
            }

            Console.WriteLine(nums.Where(el => el != 0).Sum());
        }
    }
}
