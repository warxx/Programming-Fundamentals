using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = nums.Length/4;
            int arrSize = nums.Length/2;

            var arr1 = new int[k];
            var arr2 = new int[k];
            var secondArr = new int[arrSize];

            for (int i = 0; i < k; i++)
            {
                arr1[i] = nums[i];
                arr2[i] = nums[nums.Length - i - 1];
            }

            for (int i = 0; i < arrSize; i++)
            {
                secondArr[i] = nums[i + k];
            }

            var concatArr = arr1.Reverse().Concat(arr2).ToArray();
            var resultArr = new int[arrSize];

            for (int i = 0; i < resultArr.Length; i++)
            {
                resultArr[i] = concatArr[i] + secondArr[i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
