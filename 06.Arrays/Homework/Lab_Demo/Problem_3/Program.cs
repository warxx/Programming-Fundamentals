using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];

            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long num = 0;

                if (k > i)
                {
                    for (int j = 0; j < i; j++)
                    {
                        num += arr[j];
                    }
                }
                else
                {
                    for (int j = i - k; j < i; j++)
                    {
                        num += arr[j];
                    }
                }

                arr[i] = num;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
