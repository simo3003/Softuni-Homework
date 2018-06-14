using System;
using System.Linq;
using System.Collections.Generic;

namespace Srbsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "" }; // init array with empty string
            // [venue] -> singer -> array[ticketPrice, ticketCount]
            Dictionary<string, Dictionary<string, int>> srbskoEvents =
                new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                input = Console.ReadLine().Split(' ');
                if (input[0] == "End")
                {
                    break;
                }
                string singer = "";
                string venue = "";
                int totalMoney = 0;
                int i = 0;
                try // tries for invalid input
                {
                    while (!input[i].Contains('@')) // get the singer, will run until we have reached the venue element
                    {
                        singer += input[i] + " ";
                        i++;
                    }
                    singer = singer.TrimEnd();
                    while (!int.TryParse(input[i], out _)) // get the venue, will run until we have reached the ticketPrice element
                    {
                        venue += input[i] + " ";
                        i++;
                    }
                    venue = venue.TrimEnd();
                    totalMoney = int.Parse(input[i]) * int.Parse(input[i + 1]);
                }
                catch (Exception e) // continues if there's an invalid input
                {
                    continue;
                }
                if (srbskoEvents.ContainsKey(venue))
                {
                    if (srbskoEvents[venue].ContainsKey(singer))
                    {
                        srbskoEvents[venue][singer] += totalMoney;
                    }
                    else
                    {
                        srbskoEvents[venue].Add(singer, totalMoney);
                    }
                }
                else
                {
                    srbskoEvents.Add(venue, new Dictionary<string, int> {{singer, totalMoney}});
                }
            }

            foreach (var srbskoEvent in srbskoEvents)
            {
                Console.WriteLine(srbskoEvent.Key.Substring(1)); // prints the venue
                foreach (var singer in srbskoEvent.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
