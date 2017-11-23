using System;
using System.Linq;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firsNumber = Console.ReadLine().TrimStart(new []{'0'});
            var secondNumber = Console.ReadLine().TrimStart(new []{'0'});

            if (firsNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firsNumber.Length, '0');
            }

            if (firsNumber.Length < secondNumber.Length)
            {
                firsNumber = firsNumber.PadLeft(secondNumber.Length, '0');
            }

            string result = string.Empty;
            int remainder = 0;


            for (int i = firsNumber.Length - 1; i >= 0 ; i--)
            {
                var firstDigit = byte.Parse(firsNumber[i].ToString());
                var secondDigit = byte.Parse(secondNumber[i].ToString());

                var sum = firstDigit + secondDigit + remainder;

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

            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
