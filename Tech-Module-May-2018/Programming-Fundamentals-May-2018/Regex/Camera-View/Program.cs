using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToSkip = numbers[0];
            int elementsToTake = numbers[1];
            Regex regex = new Regex(@"\|<(?<picture>\w+)");
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            List<string> allResults = new List<string>();
            foreach (Match match in matches)
            {
                string currentMatch = match.Groups["picture"].Value;
                char[] result = currentMatch.Skip(elementsToSkip).Take(elementsToTake).ToArray();
                allResults.Add(string.Join(string.Empty, result));
            }
            Console.WriteLine(string.Join(", ", allResults));
        }
    }
}
