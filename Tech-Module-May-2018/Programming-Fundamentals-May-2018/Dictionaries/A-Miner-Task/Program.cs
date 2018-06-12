using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (resource != "stop")
            {
                int amount = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += amount;
                }
                else
                {
                    resources.Add(resource, amount);
                }
                resource = Console.ReadLine();
            }
            foreach (var element in resources)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
