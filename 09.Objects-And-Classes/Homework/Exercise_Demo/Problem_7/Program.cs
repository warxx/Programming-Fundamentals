using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, decimal>();
            var customers = new List<Customer>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var productArgs = Console.ReadLine().Split('-');

                var productName = productArgs[0];
                var productPrice = decimal.Parse(productArgs[1]);

                if (!shop.ContainsKey(productName))
                {
                    shop.Add(productName, productPrice);
                }
                else
                {
                    shop[productName] = productPrice;
                }
            }

            var input = Console.ReadLine();

            while (input != "end of clients")
            {
                var customerArgs = input.Split('-');

                var customerName = customerArgs[0];
                var boughtItemArgs = customerArgs[1].Split(',');

                var productName = boughtItemArgs[0];
                var quantity = int.Parse(boughtItemArgs[1]);

                if (shop.ContainsKey(productName))
                {

                    if (customers.Any(c => c.Name == customerName))
                    {
                        var customer = customers.FirstOrDefault(c => c.Name == customerName);

                        if (!customer.BoughtProducts.ContainsKey(productName))
                        {
                            customer.BoughtProducts[productName] = quantity;
                        }
                        else
                        {
                            customer.BoughtProducts[productName] += quantity;
                        }

                        customer.Bill += quantity*shop[productName];
                    }
                    else
                    {
                        var customer = new Customer();

                        customer.Name = customerName;
                        customer.BoughtProducts = new Dictionary<string, int>
                        {
                            {productName, quantity}
                        };
                        customer.Bill += quantity * shop[productName];
                        customers.Add(customer);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var product in customer.BoughtProducts)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(c => c.Bill):F2}");
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> BoughtProducts { get; set; }
        public decimal Bill { get; set; }
    }
}
