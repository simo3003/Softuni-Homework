using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Demon> demons = new SortedDictionary<string, Demon>();
            string[] names = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string hpPattern = @"([^0-9\+\-\*\/\.])";
            string dmgPattern = @"\-?(\d)+(\.\d+)*";
            foreach (var name in names)
            {
                Demon demon = new Demon();
                MatchCollection hpMatches = Regex.Matches(name, hpPattern);
                long hp = 0;
                double dmg = 0;
                foreach (Match match in hpMatches)
                {
                    if (match.Success)
                    {
                        hp += match.Value[0];
                    }
                }

                MatchCollection dmgMatches = Regex.Matches(name, dmgPattern);
                if (dmgMatches.Count > 0)
                {
                    foreach (Match match in dmgMatches)
                    {
                        if (match.Success)
                        {
                            dmg += double.Parse(match.ToString());
                        }
                    }

                    var mult = name.Where(x => x == '*').ToList().Count;
                    var div = name.Where(x => x == '/').ToList().Count;

                    dmg *= Math.Pow(2, mult);
                    dmg /= Math.Pow(2, div);
                }
                demon.Health = hp;
                demon.Damage = dmg;
                demons.Add(name, demon);
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
            }
        }
    }

    class Demon
    {
        public long Health { get; set; } = 0;
        public double Damage { get; set; } = 0;
    }
}
