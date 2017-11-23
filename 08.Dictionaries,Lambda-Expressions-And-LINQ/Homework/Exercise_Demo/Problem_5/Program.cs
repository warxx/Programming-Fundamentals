using System;
using System.Collections.Generic;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var hands = new Dictionary<string, List<string>>();
            var points = new Dictionary<string, long>();

            var line = Console.ReadLine().Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);

            var personName = line[0];

            while (personName != "JOKER")
            {
                var cardsInHand = line[1].Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

                if (!hands.ContainsKey(personName))
                {
                    hands.Add(personName, new List<string>());
                }

                for (int i = 0; i < cardsInHand.Length; i++)
                {
                    var currentCard = cardsInHand[i];

                    if (!hands[personName].Contains(currentCard))
                    {
                        hands[personName].Add(currentCard);
                    }
                }

                line = Console.ReadLine().Split(new[] {':'}, StringSplitOptions.RemoveEmptyEntries);
                personName = line[0];
            }

            foreach (var hand in hands)
            {
                if (!points.ContainsKey(hand.Key))
                {
                    points[hand.Key] = 0;
                }

                

                foreach (var card in hand.Value)
                {
                    string power;
                    string type;

                    if (card.Length == 3)
                    {
                        char[] chars = {card[0], card[1]};
                        power = new string(chars);
                        type = card[2].ToString();
                    }
                    else
                    {
                        power = card[0].ToString();
                        type = card[1].ToString();
                    }

                    int cardPoints = GetCardPoints(power, type);
                    points[hand.Key] += cardPoints;
                }
            }

            foreach (var person in points)
            {
                Console.WriteLine($"{person.Key}: {person.Value}");
            }
        }

        private static int GetCardPoints(string power, string type)
        {
            int powerPoints = 0;
            int typePoints = 0;

            switch (power)
            {
                case "2":
                    powerPoints = 2;
                    break;
                case "3":
                    powerPoints = 3;
                    break;
                case "4":
                    powerPoints = 4;
                    break;
                case "5":
                    powerPoints = 5;
                    break;
                case "6":
                    powerPoints = 6;
                    break;
                case "7":
                    powerPoints = 7;
                    break;
                case "8":
                    powerPoints = 8;
                    break;
                case "9":
                    powerPoints = 9;
                    break;
                case "10":
                    powerPoints = 10;
                    break;
                case "J":
                    powerPoints = 11;
                    break;
                case "Q":
                    powerPoints = 12;
                    break;
                case "K":
                    powerPoints = 13;
                    break;
                case "A":
                    powerPoints = 14;
                    break;
            }

            switch (type)
            {
                case "S":
                    typePoints = 4;
                    break;
                case "H":
                    typePoints = 3;
                    break;
                case "D":
                    typePoints = 2;
                    break;
                case "C":
                    typePoints = 1;
                    break;
            }

            return powerPoints * typePoints;
        }
    }
}
