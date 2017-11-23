using System;
using System.Globalization;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);

            var steps = int.Parse(Console.ReadLine()) % 86400;
            var seconds = int.Parse(Console.ReadLine()) % 86400;

            for (int i = 0; i < steps; i++)
            {
                date = date.AddSeconds(seconds);
            }

            Console.WriteLine($"Time Arrival: {date.ToString("HH:mm:ss")}");
        }
    }
}
