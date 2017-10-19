using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            while (arr.Length != 1)
            {
                var condensed = new int[arr.Length - 1];

                for (int i = 1; i < arr.Length; i++)
                {
                    condensed[i - 1] = arr[i - 1] + arr[i];
                }
                arr = condensed;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
