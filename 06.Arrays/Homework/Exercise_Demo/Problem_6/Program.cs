using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

            int biggestLength = 0;
            int counter = 1;

            var listOfSequence = new List<int>();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    counter++;
                    if (counter > biggestLength)
                    {
                        biggestLength = counter;
                        listOfSequence = Enumerable.Repeat(arr[i], biggestLength).ToList();
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ", listOfSequence));

        }
    }
}
