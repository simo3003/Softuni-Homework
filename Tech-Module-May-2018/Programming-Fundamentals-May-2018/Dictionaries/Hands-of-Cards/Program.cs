using System;
using System.Linq;
using System.Collections.Generic;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');
            string name = input[0];
            Dictionary<string, List<string>> dealtHands = new Dictionary<string, List<string>>();
            while (input[0] != "JOKER")
            {
                List<string> cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (dealtHands.ContainsKey(name))
                {
                    dealtHands[name].AddRange(cards);
                }
                else
                {
                    dealtHands[name] = cards;
                }
                input = Console.ReadLine().Split(':');
                name = input[0];
            }

            foreach (var dealtHand in dealtHands)
            {
                int totalValue = 0;
                foreach (var card in dealtHand.Value.Distinct())
                {
                    string type = card.Substring(card.Length - 1); // get the last element
                    string power = card.Substring(0, card.Length - 1); // get the rest of the elements
                    int value = CalculatePower(power) * CalculateTypeMultiplier(type);
                    totalValue += value;
                }
                Console.WriteLine($"{dealtHand.Key}: {totalValue}");
            }
        }

        static int CalculatePower(string power)
        {
            switch (power)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return int.Parse(power);
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }

        static int CalculateTypeMultiplier(string type)
        {
            switch (type)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }
    }
}