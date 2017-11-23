using System;
using System.Collections.Generic;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SortedDictionary<string, decimal>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var sale = ReadSale();

                if (!sales.ContainsKey(sale.Town))
                {
                    sales.Add(sale.Town, 0);
                }

                sales[sale.Town] += sale.Quantity*sale.Price;
            }

            foreach (var sale in sales)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
            }
        }

        private static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');

            var town = input[0];
            var product = input[1];
            var price = decimal.Parse(input[2]);
            var quantity = decimal.Parse(input[3]);

            var sale = new Sale()
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };

            return sale;
        }
    }

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
