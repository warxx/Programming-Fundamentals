using System;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var participantNames = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var trackLayout = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var checkPoints = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < participantNames.Length; i++)
            {
                var fuel = (double)participantNames[i][0];
                int zoneIndex = 0;

                for (int j = 0; j < trackLayout.Length; j++)
                {
                    if (checkPoints.Contains(j))
                    {
                        fuel += trackLayout[j];
                    }
                    else
                    {
                        fuel -= trackLayout[j];
                    }

                    if (fuel <= 0)
                    {
                        zoneIndex = j;
                        break;
                    }
                }

                if (fuel <= 0)
                {
                    Console.WriteLine($"{participantNames[i]} - reached {zoneIndex}");
                }
                else
                {
                    Console.WriteLine($"{participantNames[i]} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
