using System;
using System.Collections.Generic;
using System.IO;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Dictionary<string, int>();

            var input = File.ReadAllLines(@"../../Input.txt");
            File.Delete(@"../../Output.txt");

            for (int i = 0; i < input.Length - 1; i+=2)
            {
                var resource = input[i];
                var quantity = int.Parse(input[i + 1]);

                if (!miner.ContainsKey(resource))
                {
                    miner[resource] = 0;
                }

                miner[resource] += quantity;
            }

            foreach (var resource in miner)
            {
                File.AppendAllText(@"../../Output.txt", $"{resource.Key} -> {resource.Value}" + Environment.NewLine);   
            }
        }
    }
}
