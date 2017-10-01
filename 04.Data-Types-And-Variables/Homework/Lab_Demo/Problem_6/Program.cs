using System;

namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < index; j++)
                {
                    for (int k = 0; k < index; k++)
                    {
                        char firstLetter = (char) ('a' + i);
                        char secondLetter = (char) ('a' + j);
                        char thirdLetter = (char) ('a' + k);

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
