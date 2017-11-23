using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCounter = 0;
            int tempCounter = 1;
            var maxSequence = new List<int>();

            var list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    tempCounter = 1;
                }

                if (tempCounter > maxCounter)
                {
                    maxCounter = tempCounter;
                    maxSequence = Enumerable.Repeat(list[i], maxCounter).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", maxSequence));
        }
    }
}
