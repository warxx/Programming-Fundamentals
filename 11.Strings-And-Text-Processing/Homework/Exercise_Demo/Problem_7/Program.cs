using System;
using System.Linq;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = int.Parse(Console.ReadLine());

            string result = string.Empty;
            int remainder = 0;


            for (int i = firsNumber.Length - 1; i >= 0; i--)
            {
                var firstDigit = byte.Parse(firsNumber[i].ToString());

                var sum = (firstDigit * secondNumber) + remainder;

                if (sum >= 10)
                {
                    var laino = sum.ToString();
                    result += laino[1];
                    remainder = int.Parse(laino[0].ToString());
                }
                else
                {
                    result += sum;
                    remainder = 0;
                }
            }

            if (remainder > 0)
            {
                result += remainder;
            }

            var HUI = result.Split(new []{'0'}, StringSplitOptions.RemoveEmptyEntries);

            if (HUI.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(result.Reverse().ToArray());
            }
        }
    }
}
