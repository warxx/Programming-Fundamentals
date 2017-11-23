using System;
using System.IO;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            var cities = new[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var rnd = new Random();

            var n = int.Parse(File.ReadAllText(@"../../Input.txt"));
            File.Delete(@"../../Output.txt");

            for (int i = 0; i < n; i++)
            {
                var phraseIndex = rnd.Next(0, phrases.Length);
                var eventIndex = rnd.Next(0, events.Length);
                var cityIndex = rnd.Next(0, cities.Length);
                var authorIndex = rnd.Next(0, authors.Length);

                var phrase = phrases[phraseIndex];
                var @event = events[eventIndex];
                var author = authors[authorIndex];
                var city = cities[cityIndex];

                File.AppendAllText(@"../../Output.txt", $"{phrase} {@event} {author} - {city}" + Environment.NewLine);
            }
        }
    }
}
