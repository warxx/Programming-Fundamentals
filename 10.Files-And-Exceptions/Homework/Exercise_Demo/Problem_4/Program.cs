using System;
using System.IO;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestLength = 1;
            int lastLength = 1;

            var input = File.ReadAllText(@"../../Input.txt");

            var numbers = input.Split(' ').Select(int.Parse).ToArray();

            int biggestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    lastLength++;

                    if (lastLength > biggestLength)
                    {
                        biggestLength = lastLength;
                        biggestNumber = numbers[i];
                    }
                }
                else
                {
                    lastLength = 1;
                }
            }

            File.WriteAllText(@"../../Output.txt", string.Join(" ", Enumerable.Repeat(biggestNumber, biggestLength)));
        }
    }
}
