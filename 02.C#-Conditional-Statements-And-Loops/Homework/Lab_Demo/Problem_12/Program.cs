using System;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n;

            if (int.TryParse(number, out n))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");                
            }
        }
    }
}
