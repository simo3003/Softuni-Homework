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
                string joinedString = string.Join(" ", input);
                string singer = "";
                string venue = "";
                int totalMoney = 0;
                int i = 0;
                try // tries for invalid input
                {
                    // checks if the character before the '@' is a space, if yes -> valid input, if no -> invalid (throws an exception)
                    int indexOfVenue = joinedString.IndexOf('@');
                    if (joinedString[indexOfVenue - 1] != ' ')
                    {
                        throw new Exception("Invalid input!");
                    }
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
                if (srbskoEvents.ContainsKey(venue)) // if the venue is in the dictionary
                {
                    if (srbskoEvents[venue].ContainsKey(singer)) // and the singer is in the venue dictionary
                    {
                        srbskoEvents[venue][singer] += totalMoney; // append the money
                    }
                    else // else add the singer and his / her money
                    {
                        srbskoEvents[venue].Add(singer, totalMoney);
                    }
                }
                else // else add the venue and the venue dictionary
                {
                    srbskoEvents.Add(venue, new Dictionary<string, int> { { singer, totalMoney } });
                }
            }

            foreach (var srbskoEvent in srbskoEvents)
            {
                Console.WriteLine(srbskoEvent.Key.Substring(1)); // prints the venue
                foreach (var singer in srbskoEvent.Value.OrderByDescending(x => x.Value)) // sorts by total money
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
