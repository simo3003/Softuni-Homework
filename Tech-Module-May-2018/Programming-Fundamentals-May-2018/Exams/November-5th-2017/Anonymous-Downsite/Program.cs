using System;
using System.Collections.Generic;
using System.Numerics;

namespace Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            long sitesHacked = long.Parse(Console.ReadLine());
            long securityKey = long.Parse(Console.ReadLine());
            List<string> hackedSites = new List<string>();
            decimal totalLoss = 0;
            for (long i = 1; i <= sitesHacked; i++)
            {
                string[] input = Console.ReadLine().Split();
                string site = input[0];
                long visits = long.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);
                totalLoss += visits * pricePerVisit;
                hackedSites.Add(site);
            }
            BigInteger securityToken = 1;
            for (int i = 0; i < sitesHacked; i++)
            {
                securityToken *= securityKey;
            }
            hackedSites.ForEach(Console.WriteLine);
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
