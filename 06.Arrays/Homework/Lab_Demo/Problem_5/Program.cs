using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');

            double[] arr = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = double.Parse(nums[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                double num;

                if (arr[i] < 0)
                {
                    num = arr[i] - 0.5;
                }
                else
                {
                    num = arr[i] + 0.5;
                }
                
                num = Math.Truncate(num);
                if (Math.Abs(arr[i]) < Math.Abs(num))
                {
                    Console.WriteLine($"{arr[i]} => {num}");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} => {Math.Truncate(arr[i])}");
                }
            }
        }
    }
}
