using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = new int[nums.Length];
            var prev = new int[nums.Length];
            var lis = new int[nums.Length][];

            len[0] = 1;
            prev[0] = -1;
            lis[0] = new[] { nums[0] };
            lis[1][0] = 33;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    for (int j = 0; j < len[i - 1]; j++)
                    {
                        lis[i][j] = 33;
                    }

                    lis[i][lis[i].Length - 1] = nums[i];

                    len[i] = len[i - 1] + 1;
                    prev[i] = prev[i - 1] + 1;

                    
                }
                else
                {
                    for (int j = prev[i]; j >= 0; j--)
                    {
                        if (nums[j] < nums[i])
                        {
                            len[i] = j;
                            break;
                        }
                    }
                }
            }
        }
    }
}
