using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> validLines = new List<string>();
            double totalSum = 0;
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^\|\$%\.]*<(?<product>\w+)>[^\|\$%\.]*\|(?<count>\d)\|([^\|\$%\.]*\|)?(?<price>[0-9]+\.?[0-9]+)\$";
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    long count = long.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    string temp = $"{name}: {product} - {count*price:f2}";
                    totalSum += count * price;
                    validLines.Add(temp);
                }
                input = Console.ReadLine();
            }
            foreach (string validLine in validLines)
            {
                Console.WriteLine(validLine);
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
