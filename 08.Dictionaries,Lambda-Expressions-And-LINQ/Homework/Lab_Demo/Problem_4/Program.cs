using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(e => e).Take(3)));
        }
    }
}
