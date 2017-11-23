using System;
using System.Collections.Generic;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();

            var resource = Console.ReadLine();

            while (resource != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resource))
                {
                    mine.Add(resource, 0);
                }

                mine[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var product in mine)
            {
                Console.WriteLine($"{product.Key} -> {product.Value}");
            }
        }
    }
}
