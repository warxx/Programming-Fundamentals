using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 59)
            {
                hour++;
                minutes -= 60;
            }

            if (hour > 23)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minutes.ToString("D2")}");
        }
    }
}
