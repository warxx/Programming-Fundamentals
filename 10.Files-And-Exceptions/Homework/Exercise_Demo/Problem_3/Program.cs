using System;
using System.IO;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var input = File.ReadAllText(@"../../Input.txt");
            var numbers = input.Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            string result = String.Empty;

            if (numbers.Length <= 1)
            {
                result = "0";
            }
            else if (numbers.Length == 2)
            {
                result = "no";
            }
            else
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += numbers[j];
                    }

                    for (int j = numbers.Length - 1; j > i; j--)
                    {
                        rightSum += numbers[j];
                    }

                    if (leftSum == rightSum)
                    {
                        result = $"{i}";
                        break;
                    }

                    leftSum = 0;
                    rightSum = 0;
                }
            }


            if (leftSum == 0 && rightSum == 0)
            {
                File.WriteAllText(@"../../Output.txt", "no");
            }
            else
            {
                File.WriteAllText(@"../../Output.txt", result);
            }
        }
    }
}
