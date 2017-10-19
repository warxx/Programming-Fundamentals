using System;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string[] nums = Console.ReadLine().Split(' ');

            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        counter++;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[i] + arr[j]}");
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
