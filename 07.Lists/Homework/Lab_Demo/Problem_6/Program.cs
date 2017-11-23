using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            var resultList = new List<int>();

            foreach (var num in list)
            {
                if (Math.Sqrt(num) == (int) Math.Sqrt(num))
                {
                    resultList.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", resultList.OrderByDescending(e => e)));
        }
    }
}
