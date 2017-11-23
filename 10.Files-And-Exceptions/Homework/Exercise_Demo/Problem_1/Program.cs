using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();

            var input = File.ReadAllText(@"../../Input.txt");

            var numbers = input.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]] = 0;
                }

                dict[numbers[i]]++;
            }

            var wantedNumber = dict.OrderByDescending(e => e.Value).FirstOrDefault();

            File.WriteAllText(@"../../Output.txt", wantedNumber.Key.ToString());
            
        }
    }
}
