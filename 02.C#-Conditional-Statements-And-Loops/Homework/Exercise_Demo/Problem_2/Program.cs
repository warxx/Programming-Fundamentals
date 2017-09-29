using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = 0.70*quantity;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = 1.00 * quantity;
                    break;
                case "SoftUni Student":
                    totalPrice = 1.70 * quantity;
                    break;
                default:
                    totalPrice = 1.20 * quantity;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
