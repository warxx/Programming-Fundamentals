using System;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int output;
            bool isInteger;
            int count = 0;

            string input = Console.ReadLine();
            isInteger = int.TryParse(input, out output);

            while (isInteger)
            {
                count++;
                input = Console.ReadLine();
                isInteger = int.TryParse(input, out output);
            }

            Console.WriteLine(count);
        }
    }
}
