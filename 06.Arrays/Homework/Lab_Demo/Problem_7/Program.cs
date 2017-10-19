using System;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            string[] firstNums = Console.ReadLine().Split(' ');
            string[] secondNums = Console.ReadLine().Split(' ');

            int arrLenght = Math.Max(firstNums.Length, secondNums.Length);
            int[] firstArr = new int[arrLenght];
            int[] secondArr = new int[arrLenght];

            if (firstNums.Length > secondNums.Length)
            {
                FillSmallerArray(secondArr, secondNums, arrLenght);
                FillArray(firstArr, firstNums, arrLenght);
            }
            else if (secondNums.Length > firstNums.Length)
            {
                FillSmallerArray(firstArr, firstNums, arrLenght);
                FillArray(secondArr, secondNums, arrLenght);
            }
            else
            {
                FillArray(firstArr, firstNums, arrLenght);
                FillArray(secondArr, secondNums, arrLenght);
            }

            var sumArr = SumArray(firstArr, secondArr, arrLenght);
            Console.WriteLine(string.Join(" ", sumArr));
        }

        private static void FillArray(int[] arr, string[] nums, int length)
        {
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }
        }

        private static int[] SumArray(int[] firstArr, int[] secondArr, int arrLength)
        {
            var arr = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = firstArr[i] + secondArr[i];
            }

            return arr;
        }

        private static void FillSmallerArray(int[] arr, string[] nums, int length)
        {
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            for (int i = nums.Length; i < length; i++)
            {
                arr[i] = arr[counter];
                counter++;
            }
        }
    }
}
