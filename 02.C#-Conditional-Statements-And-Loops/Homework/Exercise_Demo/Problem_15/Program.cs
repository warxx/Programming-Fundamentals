using System;

namespace Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int roundsCount = 0;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                roundsCount++;
                if (roundsCount%2 != 0)
                {
                    goshoHealth -= peshoDmg;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else
                {
                    peshoHealth -= goshoDmg;
                    if(peshoHealth > 0)
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                if (roundsCount%3 == 0 && goshoHealth > 0 && peshoHealth > 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }

            if (goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {roundsCount}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {roundsCount}th round.");
            }
        }
    }
}
