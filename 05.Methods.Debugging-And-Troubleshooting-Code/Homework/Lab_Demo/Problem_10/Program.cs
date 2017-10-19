using System;
using System.Globalization;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formats = new[] {"dd.M.yyyy", "dd.MM.yyyy", "d.M.yyyy", "d.MM.yyyy"};

            var startDate = DateTime.ParseExact(Console.ReadLine(),
                formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                formats, CultureInfo.InvariantCulture, DateTimeStyles.None);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
                
            Console.WriteLine(holidaysCount);
        }
    }
}
