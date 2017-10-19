using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                arr[i] = number;
            }

            int[] reversedArr = new int[n];
            int counter = 0;

            for (int i = arr.Length-1; i >= 0; i--)
            {
                reversedArr[counter] = arr[i];
                counter++;
            }

            Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}
