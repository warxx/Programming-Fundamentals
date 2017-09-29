using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            double productVolume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{(productVolume/100) * energyContent}kcal, {(productVolume/100 * sugarContent)}g sugars");
        }
    }
}
