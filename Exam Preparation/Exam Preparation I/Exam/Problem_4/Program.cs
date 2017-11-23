using System;
using System.Text.RegularExpressions;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new []{' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"\${6,10}|@{6,10}|#{6,10}|\^{6,10}";

            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Match leftMatch = Regex.Match(input[i].Substring(0, 10), pattern);
                Match rightMatch = Regex.Match(input[i].Substring(10), pattern);

                int minLength = Math.Min(leftMatch.Value.Length, rightMatch.Value.Length);

                if (leftMatch.Success && rightMatch.Success)
                {
                    string leftPart = leftMatch.Value.Substring(0, minLength);
                    string rigthPart = rightMatch.Value.Substring(0, minLength);

                    if (leftPart.Equals(rigthPart))
                    {
                        if (minLength == 10)
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - 10{leftPart[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{input[i]}\" - {minLength}{leftPart[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{input[i]}\" - no match");
                    }

                }
                else
                {
                    Console.WriteLine($"ticket \"{input[i]}\" - no match");
                }
            }
        }
    }
}
