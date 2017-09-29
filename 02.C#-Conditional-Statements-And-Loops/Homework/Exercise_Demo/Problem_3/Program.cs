using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = string.Empty;
            double totalPrice;
            double pricePerPerson = 0;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                totalPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                totalPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                totalPrice = 7500;
            }
            else
            {
                totalPrice = 0;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                switch (package)
                {
                    case "Normal":
                        totalPrice += 500;
                        totalPrice -= totalPrice * 0.05;
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Gold":
                        totalPrice += 750;
                        totalPrice -= totalPrice * 0.1;
                        pricePerPerson = totalPrice / groupSize;
                        break;
                    case "Platinum":
                        totalPrice += 1000;
                        totalPrice -= totalPrice * 0.15;
                        pricePerPerson = totalPrice / groupSize;
                        break;
                }

                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
