using System;
using System.IO;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines(@"..\..\..\Resources\01. Odd Lines\Input.txt");

            foreach (var line in lines.Where((e, i) => i % 2 == 1))
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines("../../Output.txt", lines.Where((e, i) => i % 2 == 1));
        }
    }
}
