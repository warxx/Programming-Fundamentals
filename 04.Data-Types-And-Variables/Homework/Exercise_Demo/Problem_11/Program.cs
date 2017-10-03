using System;

namespace Problem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int hoursInSeconds = hours*3600;
            int minutesInSeconds = minutes*60;

            float metersInKilometers = meters/1000;
            float secondsInHours = (float)(hoursInSeconds + minutesInSeconds + seconds)/3600;

            float metersInMiles = meters / 1609;

            float metersPerSecond = meters/(hoursInSeconds + minutesInSeconds + seconds);
            float kilometersPerHour = metersInKilometers/secondsInHours;
            float milesPerHour = metersInMiles/secondsInHours;

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
