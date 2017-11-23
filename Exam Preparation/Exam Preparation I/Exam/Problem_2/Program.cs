using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            var singers = new List<string>();
            var songs = new List<string>();

            var karaokeData = new Dictionary<string, List<string>>();

            var singersInput = Console.ReadLine();
            var songsInput = Console.ReadLine();

            var singersArr = Regex.Split(singersInput, @",\s+");
            var songsArr = Regex.Split(songsInput, @",\s+");

            for (int i = 0; i < singersArr.Length; i++)
            {
                singers.Add(singersArr[i]);
            }

            for (int i = 0; i < songsArr.Length; i++)
            {
                songs.Add(songsArr[i]);
            }

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var args = Regex.Split(input, @",\s+");

                var singer = args[0];
                var song = args[1];
                var award = args[2];

                if (singers.Contains(singer) && songs.Contains(song))
                {
                    if (!karaokeData.ContainsKey(singer))
                    {
                        karaokeData.Add(singer, new List<string>());
                    }

                    if (!karaokeData[singer].Contains(award))
                    {
                        karaokeData[singer].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            if (karaokeData.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in karaokeData.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
                {
                    Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                    foreach (var award in singer.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
