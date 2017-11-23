using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>(Console.ReadLine().Split(' ').Select(double.Parse));

            list.Sort();
            Console.WriteLine(string.Join(" <= ", list));
        }
    }
}
