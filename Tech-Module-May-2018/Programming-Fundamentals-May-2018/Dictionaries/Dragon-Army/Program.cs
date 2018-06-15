using System;
using System.Linq;
using System.Collections.Generic;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = "";
            // [type] -> { [name] -> Dragon }
            /* 5
               Red Bazgargal 100 2500 25
               Black Dargonax 200 3500 18
               Red Obsidion 220 2200 35
               Blue Kerizsa 60 2100 20
               Blue Algordox 65 1800 50 */
            // Type Name     Dmg Hp  Armor
            Dictionary<string, SortedDictionary<string, Dragon>> army = new Dictionary<string, SortedDictionary<string, Dragon>>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine(); // get the input
                string[] tempElements = input.Split(); // split by space
                string type = tempElements[0];
                string name = tempElements[1];
                string damage = tempElements[2];
                string health = tempElements[3];
                string armor = tempElements[4];
                // check for null entries and replace with default values
                if (damage == "null")
                {
                    damage = "45";
                }
                if (health == "null")
                {
                   health = "250";
                }
                if (armor == "null")
                {
                    armor = "10";
                }
                if (army.ContainsKey(type)) // check if the current type is in the army
                {
                    if (army[type].ContainsKey(name)) // check if the current dragon name is in the army
                    { 
                        army[type][name] = new Dragon // and overwrite it with the new stats
                        { 
                            Damage = damage,
                            Health = health,
                            Armor = armor
                        };
                    }
                    else
                    {
                        army[type].Add(name, new Dragon
                        {
                            Damage = damage,
                            Health = health,
                            Armor = armor
                        });
                    }
                }
                else
                {
                    army.Add(type, new SortedDictionary<string, Dragon>
                    {
                        {
                            name, new Dragon
                            {
                                Damage = damage,
                                Health = health,
                                Armor = armor
                            }
                        }
                    });
                }
            }

            foreach (var type in army)
            {
                double avgDmg = type.Value.Values.Average(x => int.Parse(x.Damage));
                double avgHp = type.Value.Values.Average(x => int.Parse(x.Health));
                double avgArmor = type.Value.Values.Average(x => int.Parse(x.Armor));
                Console.WriteLine($@"{type.Key}::({avgDmg:f2}/{avgHp:f2}/{avgArmor:f2})");
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public string Damage { get; set; }
        public string Health { get; set; }
        public string Armor { get; set; }
    }
}
