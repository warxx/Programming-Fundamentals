using System;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string chArr = Console.ReadLine();

            for (int i = 0; i < chArr.Length; i++)
            {
                var letter = Convert.ToChar(chArr[i]);
                Console.WriteLine($"{letter} -> {Convert.ToInt32(letter) - 97}");
            }
        }
    }
}
