using System;
using System.Globalization;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDate = Console.ReadLine();

            var date = new DateTime();
            date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
