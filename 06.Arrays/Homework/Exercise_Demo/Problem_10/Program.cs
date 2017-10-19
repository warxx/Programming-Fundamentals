using System;
using System.Linq;

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                        if (nums[i] - nums[j] == difference || nums[j] - nums[i] == difference)
                        {
                            counter++;
                        }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
