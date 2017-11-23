using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var aggregator = new Dictionary<string, Dictionary<string, int>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(' ');

                var ip = input[0];
                var username = input[1];
                var duration = int.Parse(input[2]);

                if (!aggregator.ContainsKey(username))
                {
                    aggregator.Add(username, new Dictionary<string, int>());
                }

                if (!aggregator[username].ContainsKey(ip))
                {
                    aggregator[username].Add(ip, duration);
                }
                else
                {
                    aggregator[username][ip] += duration;
                }
            }

            foreach (var user in aggregator.OrderBy(e => e.Key))
            {
                string result = $"{user.Key}: {user.Value.Sum(e => e.Value)} [";

                foreach (var ip in user.Value.OrderBy(e => e.Key))
                {
                    result += $"{ip.Key}, ";
                }

                result = result.Remove(result.Length - 2) + "]";
                Console.WriteLine(result);
            }
        }
    }
}
