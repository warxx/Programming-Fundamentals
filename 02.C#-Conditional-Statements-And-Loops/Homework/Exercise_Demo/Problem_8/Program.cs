using System;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int cheeseCalories = 500;
            int tomatoSauceCalories = 150;
            int salamiCalories = 600;
            int pepperCalories = 50;
            int totalCalories = 0;

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCalories += cheeseCalories;
                        break;
                    case "tomato sauce":
                        totalCalories += tomatoSauceCalories;
                        break;
                    case "salami":
                        totalCalories += salamiCalories;
                        break;
                    case "pepper":
                        totalCalories += pepperCalories;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
