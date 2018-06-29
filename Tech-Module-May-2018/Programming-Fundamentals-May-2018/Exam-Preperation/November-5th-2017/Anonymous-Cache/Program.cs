using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
            while (input != "thetinggoesskrra")
            {
                string[] splitInput = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (splitInput.Length == 1)
                {
                    string dataSet = splitInput[0];
                    if (cache.ContainsKey(dataSet)) // ??? NOTE: Elements in the cache, should be CONSIDERED NON-EXISTANT. You should NOT count them in the final output. ???
                    {
                        data.Add(dataSet, cache[dataSet]);
                    }
                    else
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                else
                {
                    string dataSet = splitInput[2];
                    string dataKey = splitInput[0];
                    long dataSize = long.Parse(splitInput[1]);
                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache.Add(dataSet, new Dictionary<string, long>
                            {
                                {dataKey, dataSize}
                            });
                        }
                    }
                }
                input = Console.ReadLine();
            }

            if (data.Count > 0)
            {
                var biggestDataSet = data.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault();
                Console.WriteLine($"Data Set: {biggestDataSet.Key}, Total Size: {biggestDataSet.Value.Values.Sum()}");
                foreach (var dataKeys in biggestDataSet.Value)
                {
                    Console.WriteLine($"$.{dataKeys.Key}");
                }
            }
            
        }
    }
}
