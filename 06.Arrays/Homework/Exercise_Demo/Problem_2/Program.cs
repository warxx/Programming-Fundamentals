using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            var rotations = int.Parse(Console.ReadLine());

            int[] arr = new int[nums.Length];
            int[][] arrs = new int[rotations][];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            for (int i = 0; i < rotations; i++)
            {
                var rotatedArr = new int[arr.Length];
                rotatedArr[0] = arr[arr.Length - 1];

                for (int j = 1; j < arr.Length; j++)
                {
                    rotatedArr[j] = arr[j - 1];
                }

               // rotatedArr[rotatedArr.Length - 1] = arr[0];
                arr = rotatedArr;
                arrs[i] = rotatedArr;
            }

            var sum = new int[arr.Length];

            for (int i = 0; i < arrs.Length; i++)
            {
                for (int j = 0; j < arrs[i].Length; j++)
                {
                    sum[j] += arrs[i][j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
