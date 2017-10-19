using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');

            int k = nums.Length/4;

            var leftArr = new int[k];
            var rightArr = new int[k];
            var middleArr = new int[k*2];

            for (int i = 0; i < k; i++)
            {
                leftArr[i] = int.Parse(nums[i]);
            }

            for (int i = k*3; i < nums.Length; i++)
            {
                rightArr[i - (k*3)] = int.Parse(nums[i]);
            }
            
            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            for (int i = leftArr.Length; i < k * 3; i++)
            {
                middleArr[i - (leftArr.Length)] = int.Parse(nums[i]);
            }

            var list = new List<int>();

            list.AddRange(leftArr);
            list.AddRange(rightArr);

            var concateArray = list.ToArray();
            var finalArray = new int[k * 2];

            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = concateArray[i] + middleArr[i];
            }

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
