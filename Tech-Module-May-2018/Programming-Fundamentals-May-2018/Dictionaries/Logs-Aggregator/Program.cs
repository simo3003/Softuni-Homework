using System;
using System.Linq;
using System.Collections.Generic;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            int counter = 1;
            while (counter <= n)
            {
                string input = Console.ReadLine();
                string[] tempElements = input.Split(' ').ToArray();
                string ip = tempElements[0];
                string user = tempElements[1];
                int duration = int.Parse(tempElements[2]);
                if (logs.ContainsKey(user))
                {
                    if (logs[user].ContainsKey(ip))
                    {
                        logs[user][ip] += duration;
                    }
                    else
                    {
                        logs[user].Add(ip, duration);
                    }
                }
                else
                {
                    logs.Add(user, new SortedDictionary<string, int> {{ip, duration}});
                }
                counter++;
            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ",user.Value.Keys)}]");
            }
        }
    }
}
