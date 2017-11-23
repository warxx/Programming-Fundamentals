using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            var nums = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            var args = Console.ReadLine().Split(' ');

            while (args[0] != "Odd" && args[0] != "Even")
            {
                switch (args[0])
                {
                    case "Delete":
                        int item = int.Parse(args[1]);
                        nums.RemoveAll(e => e == item);
                        break;
                    case "Insert":
                        int element = int.Parse(args[1]);
                        int index = int.Parse(args[2]);
                        nums.Insert(index, element);
                        break;
                }

                args = Console.ReadLine().Split(' ');
            }

            if (args[0] == "Odd")
            {
                Console.WriteLine(string.Join(" ", nums.Where(e => e % 2 != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums.Where(e => e % 2 == 0)));
            }
        }
    }
}
