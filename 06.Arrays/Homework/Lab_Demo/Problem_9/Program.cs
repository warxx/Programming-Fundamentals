using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            int length = nums.Length;

            if (length == 1)
            {
                Console.WriteLine("{ " + $"{nums[0]}" + " }");
            }
            else if (length%2 == 0)
            {
                string num1 = nums[(length/2) - 1];
                string num2 = nums[length /2];
                Console.WriteLine("{ " + $"{num1}, {num2}" + " }");
            }
            else
            {
                string num1 = nums[(length / 2) - 1];
                string num2 = nums[length / 2];
                string num3 = nums[(length / 2) + 1];
                Console.WriteLine("{ " + $"{num1}, {num2}, {num3}" + " }");
            }
        }
    }
}
