using System;
using System.Linq;
using System.Collections.Generic;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> totalMaterials = new Dictionary<string, int>
            {
                { "shards", 0},
                { "fragments", 0},
                { "motes", 0}
            };
            while (true)
            {
                string input = Console.ReadLine();
                List<string> farmedMaterials = input.Split(' ').ToList();
                // 3 motes 5 stones 5 shards
                // 0 1     2 3      4 5     <- indexes
                //   ^       ^        ^ 
                // materials are at every odd index
                for (int i = 1; i <= farmedMaterials.Count; i += 2) // check every odd index 
                {
                    string currentMaterial = farmedMaterials[i].ToLower(); // current index is the material - case sensitive
                    int quantity = int.Parse(farmedMaterials[i - 1]); // previous element is the quantity of the material
                    if (totalMaterials.ContainsKey(currentMaterial)) // if the material already exists
                    {
                        totalMaterials[currentMaterial] += quantity; ; // append the current quantity
                    }
                    else
                    {
                        totalMaterials.Add(currentMaterial, quantity); // else add it 
                    }

                    if (currentMaterial == "shards" || currentMaterial == "fragments" || currentMaterial == "motes") // check if the current item is a "key" item
                    {
                        if (totalMaterials[currentMaterial] >= 250) // do we have enough to buy a legendary?
                        {
                            BuyLegendary(totalMaterials, currentMaterial); // if yes, lets buy one
                            return;
                        }
                    }
                }
            }
        }

        static void BuyLegendary(Dictionary<string, int> totalMaterials, string winningMaterial)
        {
            switch (winningMaterial) // which legendary can we buy?
            {
                case "shards":
                    totalMaterials["shards"] -= 250;
                    Console.WriteLine("Shadowmourne obtained!");
                    PrintRemaningMaterials(totalMaterials);
                    return;
                case "fragments":
                    totalMaterials["fragments"] -= 250;
                    Console.WriteLine("Valanyr obtained!");
                    PrintRemaningMaterials(totalMaterials);
                    return;
                case "motes":
                    totalMaterials["motes"] -= 250;
                    Console.WriteLine("Dragonwrath obtained!");
                    PrintRemaningMaterials(totalMaterials);
                    return;
            }
        }

        static void PrintRemaningMaterials(Dictionary<string, int> totalMaterials)
        {
            foreach (var material in totalMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) // print the key materials first
            {
                if (material.Key == "motes" || material.Key == "shards" || material.Key == "fragments")
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }
            }

            foreach (var material in totalMaterials.OrderBy(x => x.Key))
            {
                if (material.Key != "motes" && material.Key != "shards" && material.Key != "fragments")
                {
                    Console.WriteLine($"{material.Key}: {material.Value}");
                }
            }
        }
    }
}
