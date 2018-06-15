using System;
using System.Linq;
using System.Collections.Generic;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            // [userName] -> { [ip] -> messageAmountWithIp }
            SortedDictionary<string, Dictionary<string, int>> log = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tempElements = input.Split(' ').ToArray();
                string ip = tempElements[0].Substring(3); // IP=
                string userName = tempElements[2].Substring(5); // user=
                if (log.ContainsKey(userName))
                {
                    if (log[userName].ContainsKey(ip))
                    {
                        log[userName][ip]++;
                    }
                    else
                    {
                        log[userName].Add(ip, 1);
                    }
                }
                else
                {
                    log.Add(userName, new Dictionary<string, int> { { ip, 1 } });
                }
                input = Console.ReadLine();
            }
            foreach (var user in log)
            {
                Console.WriteLine($"{user.Key}:");
                string result = "";
                foreach (var ip in user.Value)
                {
                    result += $"{ip.Key} => {ip.Value}, ";
                }
                result = result.Substring(0, result.Length - 2);
                result += ".";
                Console.WriteLine(result);
            }
        }
    }
}
