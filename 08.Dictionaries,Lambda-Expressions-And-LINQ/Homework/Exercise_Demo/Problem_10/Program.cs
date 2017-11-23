using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            var srybsko = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var args = input.Split('@');

                var singer = args[0];

                if (!singer.EndsWith(" ") || singer.Length < 2)
                {
                    input = Console.ReadLine();
                    continue;
                }

                singer = singer.Trim();

                var singerArgs = args[1].Split(' ');

                int ticketsCount = 0;
                int ticketsPrice = 0;

                if (singerArgs.Length < 3 
                    || !int.TryParse(singerArgs[singerArgs.Length - 1], out ticketsCount)
                    || !int.TryParse(singerArgs[singerArgs.Length - 2], out ticketsPrice))
                {
                    input = Console.ReadLine();
                    continue;
                }

                ticketsCount = int.Parse(singerArgs[singerArgs.Length - 1]);
                ticketsPrice = int.Parse(singerArgs[singerArgs.Length - 2]);

                var venue = "";

                for (int i = 0; i < singerArgs.Length - 2; i++)
                {
                    venue += singerArgs[i] + " ";
                }

                venue = venue.Trim();

                /*if (singer.Any(c => char.IsDigit(c)) || venue.Any(c => char.IsDigit(c)))
                {
                    input = Console.ReadLine();
                    continue;
                }*/

                if (!srybsko.ContainsKey(venue))
                {
                    srybsko.Add(venue, new Dictionary<string, long>());
                    srybsko[venue].Add(singer, ticketsPrice*ticketsCount);
                }
                else
                {
                    if (!srybsko[venue].ContainsKey(singer))
                    {
                        srybsko[venue].Add(singer, ticketsPrice*ticketsCount);
                    }
                    else
                    {
                        srybsko[venue][singer] += ticketsPrice*ticketsCount;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var venue in srybsko)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venue.Value.OrderByDescending(e => e.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
