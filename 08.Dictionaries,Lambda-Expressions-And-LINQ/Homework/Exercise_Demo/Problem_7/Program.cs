using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var populationCenter = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine().Split('|');

            while (input[0] != "report")
            {
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                if (!populationCenter.ContainsKey(country))
                {
                    populationCenter.Add(country, new Dictionary<string, long>());
                }

                
                populationCenter[country].Add(city, population);

                input = Console.ReadLine().Split('|');
            }

            foreach (var country in populationCenter.OrderByDescending(e => e.Value.Sum(c => c.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(c => c.Value)})");

                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
