using System;
using System.Linq;

namespace Problem_18
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] args = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            while (!command.Equals("stop"))
            {
                if (command.Equals("add") ||
                    command.Equals("subtract") ||
                    command.Equals("multiply"))
                {
                    int[] nums = new int[2];

                    nums[0] = int.Parse(args[1]);
                    nums[1] = int.Parse(args[2]);

                    PerformAction(array, command, nums);
                }
                else
                {
                    PerformAction(array, command);
                }

                PrintArray(array);

                args = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                command = args[0];
            }
        }

        static void PerformAction(long[] arr, string action, int[] nums)
        {
          //  long[] array = arr.Clone() as long[];
            int pos = nums[0];
            if (pos != 0)
            {
                pos--;
            }

            int value = nums[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
            }
        }

        static void PerformAction(long[] arr, string action)
        {
            long[] array = arr.Clone() as long[];

            switch (action)
            {
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }

            //arr = array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastDig = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastDig;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstDig = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstDig;
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
