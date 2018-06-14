using System;
using System.Linq;
using System.Collections.Generic;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // [country] -> town -> population
            Dictionary<string, Dictionary<string, long>> report = new Dictionary<string, Dictionary<string, long>>();
            while (input != "report")
            {
                string[] tempElements = input.Split('|').ToArray();
                string town = tempElements[0];
                string country = tempElements[1];
                long population = long.Parse(tempElements[2]);
                if (report.ContainsKey(country))
                {
                    report[country].Add(town, population);
                }
                else
                {
                    report.Add(country, new Dictionary<string, long> { { town, population } });
                }
                input = Console.ReadLine();
            }
            foreach (var country in report.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var town in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
        }
    }
}
