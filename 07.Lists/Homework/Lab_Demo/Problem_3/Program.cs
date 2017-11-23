using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse));

            int i = 0;

            while (i < list.Count - 1)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] == list[j + 1])
                    {
                        var firstNum = list[j];
                        var secondNum = list[j + 1];

                        list.RemoveRange(j, 2);
                        list.Insert(j, firstNum + secondNum);
                        i = 0;
                        break;
                    }
                    i++;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
