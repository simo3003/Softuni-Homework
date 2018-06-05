using System;
using System.Collections.Generic;
using System.Linq;
namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var uniqueNumbers = input.Distinct().ToList();
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
            foreach (int uniqueNumber in uniqueNumbers)
            {
                numberCount.Add(uniqueNumber,0);
            }
            foreach (int number in input)
            {
                numberCount[number]++;
            }
            int max = numberCount.Values.Max();
            var numberCount2 = new Dictionary<int, int>(numberCount);
            foreach (var number in numberCount2)
            {
                if (number.Value != max)
                {
                    numberCount.Remove(number.Key);
                }
            }
            Console.WriteLine(numberCount.First().Key);
        }
    }
}
