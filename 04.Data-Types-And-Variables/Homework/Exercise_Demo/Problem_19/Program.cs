using System;

namespace Problem_19
{
    class Program
    {
        static void Main()
        {
            long numberOfPrictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactorPercentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(numberOfPrictures*(double) filterFactorPercentage/100);

            long totalFilterTime = numberOfPrictures*filterTime;
            long totalUploadTime = (long)filteredPictures*uploadTime;

            long totalTime = totalFilterTime + totalUploadTime;

            var timeSpan = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine(timeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
