using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnery = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: " + new string('|', currentHealth + 1));
            Console.WriteLine(new string('.', maxHealth - currentHealth) + "|");
            Console.Write("Energy: " + new string('|', currentEnergy + 1));
            Console.WriteLine(new string('.', maxEnery - currentEnergy) + "|");
        }
    }
}
