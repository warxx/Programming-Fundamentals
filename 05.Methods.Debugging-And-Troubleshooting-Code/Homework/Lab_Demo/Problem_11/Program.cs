using System;

namespace Problem_11
{
    class Program
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());

            double significance = double.Parse(Console.ReadLine());

            double startingPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double changedPrice = double.Parse(Console.ReadLine());
                double diff = GetDifference(startingPrice, changedPrice);
                bool isSignificantDifference = IsSignificantDifference(diff, significance);
                
                string message = Get(changedPrice, startingPrice, diff, isSignificantDifference);
                Console.WriteLine(message);

                startingPrice = changedPrice;
            }
        }

        private static string Get(double changedPrice, double startingPrice, double diff, bool isSignificantDifference)
        {
            if (diff == 0)
            {
                return string.Format("NO CHANGE: {0}", changedPrice);
            }

            if (!isSignificantDifference)
            {
                return string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", startingPrice, changedPrice, diff * 100);
            }

            if (isSignificantDifference && (diff > 0))
            {
                return string.Format("PRICE UP: {0} to {1} ({2:F2}%)", startingPrice, changedPrice, diff*100);
            }

            return string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", startingPrice, changedPrice, diff * 100);
        }

        private static bool IsSignificantDifference(double diff, double significance)
        {
            if (Math.Abs(diff) >= significance)
            {
                return true;
            }

            return false;
        }

        private static double GetDifference(double startingPrice, double changedPrice)
        {
            return (changedPrice - startingPrice) / startingPrice;
        }
    }
}
