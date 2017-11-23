using System;
using System.Numerics;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonLengthInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var avgNumberOfLaps = int.Parse(Console.ReadLine());
            var lengthOfTrack = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var amountOfMoneyPerKm = decimal.Parse(Console.ReadLine());

            BigInteger totalRunners = trackCapacity*marathonLengthInDays;

            if (totalRunners > numberOfRunners)
            {
                totalRunners = numberOfRunners;
            }

            BigInteger totalMeters = totalRunners*avgNumberOfLaps*lengthOfTrack;
            double totalKilometers = (double)totalMeters/1000;

            decimal moneyRaised = (decimal)totalKilometers*amountOfMoneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
