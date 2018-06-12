using System;
using System.Linq;
using System.Collections.Generic;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> hands = new Dictionary<string, List<string>>();
            while (input != "JOKER")
            {
                string name = input.Split(':')[0];
                List<string> cards = input.Split(' ', ',', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToList();
                if (hands.ContainsKey(name))
                {
                    hands[name].AddRange(cards);
                }
                else
                {
                    hands.Add(name, cards);
                }
                input = Console.ReadLine();
            }
            foreach (var hand in hands)
            {
                int currentSum = 0;
                foreach (string card in hand.Value.Distinct())
                {
                    currentSum +=
                        GetRankPower(card.Substring(0, card.Length - 1)) * GetSuitPower(card.Substring(card.Length - 1));
                }
                Console.WriteLine($"{hand.Key}: {currentSum}");
            }
        }
        public static int GetRankPower(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
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

        public static int GetSuitPower(string suit)
        {
            switch (suit)
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
