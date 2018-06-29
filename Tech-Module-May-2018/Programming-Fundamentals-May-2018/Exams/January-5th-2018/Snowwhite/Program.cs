using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new List<Dwarf>(); // color -> dwarf
            string pattern = @"(?<name>[^ <:>]+) <:> (?<color>[^ <:>]+) <:> (?<physics>\d+)";
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                // check for success?
                Match match = Regex.Matches(input, pattern)[0];
                string name = match.Groups["name"].Value;
                string color = match.Groups["color"].Value;
                int physics = int.Parse(match.Groups["physics"].Value);
                if (dwarfs.Count(x => x.Name == name && x.Color == color) > 0) // if there is a dwarf with that name AND color
                {
                    int oldPhysics = dwarfs.FirstOrDefault(x => x.Name == name && x.Color == color).Physics;
                    dwarfs.FirstOrDefault(x => x.Name == name && x.Color == color).Physics =
                        Math.Max(physics, oldPhysics); // REPLACE PHYSICS
                }
                else
                {
                    dwarfs.Add(new Dwarf(name, color, physics)); // ADD 
                }
                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs.Count(m => m.Color == x.Color)))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }

        public Dwarf(string name, string color, int physics)
        {
            Name = name;
            Color = color;
            Physics = physics;
        }
    }
}
