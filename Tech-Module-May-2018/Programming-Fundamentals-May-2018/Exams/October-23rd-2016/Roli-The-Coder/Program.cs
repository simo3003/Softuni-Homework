using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30/100 ??
            string input = Console.ReadLine();
                                // can id be non-numeric?
                                // id    -> {name -> members}  DISTINCT THE LIST
            var db = new Dictionary<string, SortedDictionary<string, List<string>>>();
            string idAndNamePattern = @"(?<id>\d+) #(?<name>[A-Za-z0-9\-\']+)";
            string memberPattern = @"(@[A-Za-z'\-]+)";
            while (input != "Time for Code")
            {
                if (!input.Contains("@") || !input.Contains("#")) // if input is invalid
                {
                    input = Console.ReadLine();
                    continue;
                }

                // VALIDATE ?
                string id = Regex.Match(input, idAndNamePattern).Groups["id"].Value;
                string name = Regex.Match(input, idAndNamePattern).Groups["name"].Value;

            

                if (!db.ContainsKey(id)) // init
                {
                    SortedDictionary<string, List<string>> temp = new SortedDictionary<string, List<string>>();
                    temp.Add(name, new List<string>());
                    temp[name] = input
                        .Substring(input.IndexOf("@"))
                        .Split()
                        .Where(x => Regex.IsMatch(x, memberPattern))
                        .ToList();
                    db.Add(id, temp);
                }
                else
                {
                    if (db[id].ContainsKey(name))
                    {
                        if (input.Contains("@")) // if the input contains members
                        {
                            var members = input
                                .Substring(input.IndexOf("@"))
                                .Split()
                                .Where(x => Regex.IsMatch(x, memberPattern))
                                .ToList();
                            db[id][name].AddRange(members);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var id in db.OrderByDescending(x => x.Value.Values.Distinct().Count()))
            {
                foreach (var @event in id.Value)
                {
                    Console.WriteLine($"{@event.Key} - {@event.Value.Distinct().Count()}");
                    foreach (var member in @event.Value.Distinct().OrderBy(x => x))
                    {
                        Console.WriteLine(member);
                    }
                }
               
            }

        }
    }
}
