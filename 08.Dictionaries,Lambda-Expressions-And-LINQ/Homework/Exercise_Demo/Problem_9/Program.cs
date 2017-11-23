using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 },
            };
            var junkMaterials = new Dictionary<string, int>();

            bool isItemObtained = false;

            var input = Console.ReadLine().Split(' ').Select(e => e.ToLower()).ToArray();
            
            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    var material = input[i + 1];
                    var quantity = int.Parse(input[i]);

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            isItemObtained = true;

                            switch (material)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }
                }

                if (isItemObtained)
                {
                    break;
                }

                input = Console.ReadLine().Split(' ').Select(e => e.ToLower()).ToArray();
            }

            

            foreach (var material in keyMaterials.OrderByDescending(e => e.Value).ThenBy(e => e.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junkMaterials.OrderBy(e => e.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
