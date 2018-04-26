using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            string period = Console.ReadLine();
            string type = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());
            double sum = 0;
            double multiplier = 0;
            switch (type)
            {
                case "Small":
                    if (period == "one")
                    {
                        multiplier = 9.98;
                    }
                    else if (period == "two")
                    {
                        multiplier = 8.58;
                    }
                    break;
                case "Middle":
                    if (period == "one")
                    {
                        multiplier = 18.99;
                    }
                    else if (period == "two")
                    {
                        multiplier = 17.09;
                    }
                    break;
                case "Large":
                    if (period == "one")
                    {
                        multiplier = 25.98;
                    }
                   else if (period == "two")
                    {
                        multiplier = 23.59;
                    }
                    break;
                case "ExtraLarge":
                    if (period == "one")
                    {
                        multiplier = 35.99;
                    }
                   else if (period == "two")
                    {
                        multiplier = 31.79;
                    }
                    break;
            }
            if (internet == "yes")
            {
                if (multiplier <= 10)
                {
                    multiplier = multiplier + 5.50;
                }
                else if (multiplier <= 30)
                {
                    multiplier = multiplier + 4.35;
                }
                else if (multiplier >= 30)
                {
                    multiplier = multiplier + 3.85;
                }
            }
            sum = months * multiplier;
            if (period == "two")
            {
                sum = sum - sum * 0.0375;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
