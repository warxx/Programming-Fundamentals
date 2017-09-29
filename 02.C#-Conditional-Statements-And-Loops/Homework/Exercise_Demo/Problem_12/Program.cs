using System;
using System.Threading;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int startM = 1;
            int maxSum = int.Parse(Console.ReadLine());
            int combinationsCount = 0;

            int combinationResult = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    combinationResult += 3 * (i * j);
                    combinationsCount++;

                    if (combinationResult > maxSum)
                    {
                        break;
                    }
                }

                if (combinationResult > maxSum)
                {
                    break;
                }

            }

            if (combinationResult >= maxSum)
            {
                Console.WriteLine($"{combinationsCount} combinations");
                Console.WriteLine($"Sum: {combinationResult} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations");
                Console.WriteLine($"Sum: {combinationResult}");
            }
        }
    }
}
