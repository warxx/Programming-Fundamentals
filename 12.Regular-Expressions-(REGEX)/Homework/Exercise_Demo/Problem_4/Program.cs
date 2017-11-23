using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            var forecasts = new List<Forecast>();

            var input = Console.ReadLine();

            var pattern = @"(?<=^|[a-zA-Z0-9])([A-Z]{2})([0-9]+\.[0-9]+)([a-zA-Z]+)(?=\|)";

            while (input != "end")
            {
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(input, pattern);

                var city = match.Groups[1].Value;
                var avgTemp = decimal.Parse(match.Groups[2].Value);
                var type = match.Groups[3].Value;



                if (forecasts.Any(f => f.City == city))
                {
                    var forecast = forecasts.FirstOrDefault(f => f.City == city);
                    forecast.AvgTemp = avgTemp;
                    forecast.Type = type;
                }
                else
                {
                    var forecast = new Forecast()
                    {
                        City = city,
                        AvgTemp = avgTemp,
                        Type = type
                    };

                    forecasts.Add(forecast);
                }

                input = Console.ReadLine();
            }

            foreach (var forecast in forecasts.OrderBy(f => f.AvgTemp))
            {
                Console.WriteLine($"{forecast.City} => {forecast.AvgTemp:F2} => {forecast.Type}");
            }
        }

        public class Forecast
        {
            public string City { get; set; }
            public decimal AvgTemp { get; set; }
            public string Type { get; set; }
        }
    }
}
