using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = new List<DateTime>();

            int workingDaysCounter = 0;

            var inputStartDate = Console.ReadLine();
            var inputEndDate = Console.ReadLine();

            var startDate = new DateTime();
            var endDate = new DateTime();

            startDate = DateTime.ParseExact(inputStartDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            endDate = DateTime.ParseExact(inputEndDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int year = startDate.Year;

            holidays.Add(new DateTime(year, 1, 1));
            holidays.Add(new DateTime(year, 3, 3));
            holidays.Add(new DateTime(year, 5, 1));
            holidays.Add(new DateTime(year, 5, 6));
            holidays.Add(new DateTime(year, 5, 24));
            holidays.Add(new DateTime(year, 9, 6));
            holidays.Add(new DateTime(year, 9, 22));
            holidays.Add(new DateTime(year, 11, 1));
            holidays.Add(new DateTime(year, 12, 24));
            holidays.Add(new DateTime(year, 12, 25));
            holidays.Add(new DateTime(year, 12, 26));

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (holidays.Any(d => d.Day == startDate.Day && d.Month == startDate.Month) || startDate.DayOfWeek == DayOfWeek.Saturday ||
                    startDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    startDate = startDate.AddDays(1);
                    continue;
                }

                startDate = startDate.AddDays(1);
                workingDaysCounter++;
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
