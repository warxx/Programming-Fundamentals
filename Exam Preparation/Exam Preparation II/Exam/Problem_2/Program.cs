using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var arr = new int[size];

            arr = arr.Select(e => e = 0).ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < arr.Length && indexes[i] >= 0)
                {
                    arr[indexes[i]] = 1;
                }
            }

            var command = Console.ReadLine();

            while (command != "end")
            {
                var args = command.Split(' ');

                int index = int.Parse(args[0]);
                string direction = args[1];
                int length = int.Parse(args[2]);

                if (index >= arr.Length || index < 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (arr[index] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (length < 0)
                {
                    if (direction == "right")
                    {
                        direction = "left";
                    }
                    else
                    {
                        direction = "right";
                    }
                }

                arr[index] = 0;

                if (direction == "right")
                {
                    if (index + length >= arr.Length)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int i = index + length; i < arr.Length; i++)
                    {
                        if (arr[i] == 0)
                        {
                            arr[i] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    if (index - length < 0)
                    {
                        continue;
                    }

                    for (int i = index - length; i >= 0; i--)
                    {
                        if (arr[i] == 0)
                        {
                            arr[i] = 1;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
