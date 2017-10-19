using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();

            int biggestLength = 1;
            int counter = 1;

            int[] listOfSequence = null;

            var temporaryList = new List<int>();

            temporaryList.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    counter++;
                    temporaryList.Add(arr[i]);

                    if (counter > biggestLength)
                    {
                        biggestLength = counter;
                        listOfSequence = temporaryList.ToArray();
                    }
                }
                else
                {
                    temporaryList.Clear();
                    temporaryList.Add(arr[i]);
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ", listOfSequence));
        }
    }
}
