using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            decimal totalStudioPrice = 0;
            decimal totalDoublePrice = 0;
            decimal totalSuitePrice = 0;

            switch (month)
            {
                case "May":
                    if (nightsCount > 7)
                    {
                        decimal studioPricePerNight = 50 * 0.95m;
                        totalStudioPrice = studioPricePerNight * nightsCount;
                    }
                    else
                    {
                        totalStudioPrice = 50 * nightsCount;
                    }
                    totalDoublePrice = 65 * nightsCount;
                    totalSuitePrice = 75 * nightsCount;

                    break;
                case "October":
                    if (nightsCount > 7)
                    {
                        decimal studioPricePerNight = 50 *0.95m;
                        totalStudioPrice = studioPricePerNight*(nightsCount-1);
                    }
                    else
                    {
                        totalStudioPrice = 50*nightsCount;
                    }
                    totalDoublePrice = 65*nightsCount;
                    totalSuitePrice = 75*nightsCount;

                    break;
                case "June":
                    if (nightsCount > 14)
                    {
                        decimal doublePricePerNight = 72 * 0.9m;
                        totalDoublePrice = doublePricePerNight * nightsCount;
                    }
                    else
                    {
                        totalDoublePrice = 72 * nightsCount;
                    }

                    totalStudioPrice = 60*nightsCount;
                    totalSuitePrice = 82 * nightsCount;
                    break;
                case "September":
                    if (nightsCount > 14)
                    {
                        decimal doublePricePerNight = 72*0.9m;
                        totalDoublePrice = doublePricePerNight*nightsCount;
                    }
                    else
                    {
                        totalDoublePrice = 72*nightsCount;
                    }

                    if (nightsCount > 7)
                    {
                        totalStudioPrice = 60*(nightsCount - 1);
                    }
                    else
                    {
                        totalStudioPrice = 60*nightsCount;
                    }

                    totalSuitePrice = 82*nightsCount;
                    break;
                case "July":
                case "August":
                case "December":
                    if (nightsCount > 14)
                    {
                        decimal suitePricePerNight = 89*0.85m;
                        totalSuitePrice = suitePricePerNight*nightsCount;
                    }
                    else
                    {
                        totalSuitePrice = 89*nightsCount;
                    }

                    totalStudioPrice = 68*nightsCount;
                    totalDoublePrice = 77*nightsCount;
                    break;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:F2} lv.");
        }
    }
}
