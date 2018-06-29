using System;
using System.Collections.Generic;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSamples = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string[]> samples = new List<string[]>(); // keep all the samlpes
            while (input != "Clone them!") // add all the samples
            {
                string[] currentSample = input.Split('!', StringSplitOptions.RemoveEmptyEntries); // get an array of each cell
                if (currentSample.Length > lengthOfSamples) // check if the current sample is longer than the max allowed
                {
                    input = Console.ReadLine();
                    continue;
                }
                samples.Add(currentSample);
                input = Console.ReadLine();
            }
            int bestSampleIndex = 0; // index in the "samples" list
            int bestSeqLength = 0;
            int bestSeqIndex = 0;
            int bestSeqSum = 0;
            for (int i = 0; i < samples.Count; i++) // start checking each sample
            {
                // temp for current sample
                int currentIndex = 0;
                int currentLength = 0;
                int currentSum = samples[i].Select(int.Parse).Sum();
                // best for current sample
                int currentBestIndex = 0;
                int currentBestLength = 0;
                for (int j = 0; j < samples[i].Length; j++) // find the longest subsequence of "1"s in the current sample
                {
                    if (samples[i][j] == "1")
                    {
                        currentLength++;
                    }
                    else
                    {
                        currentIndex = j + 1;
                        currentLength = 0;
                    }
                    if (currentLength > currentBestLength)
                    {
                        currentBestIndex = currentIndex;
                        currentBestLength = currentLength;
                    }
                }
                if (i == 0) // if it's the first sample, set these values
                {
                    bestSeqLength = currentBestLength;
                    bestSeqIndex = currentBestIndex;
                    bestSeqSum = currentSum;
                    bestSampleIndex = i;
                    continue;
                }
                if (currentBestLength >= bestSeqLength &&
                    currentBestIndex < bestSeqIndex)
                {
                    bestSeqLength = currentLength;
                    bestSeqIndex = currentBestIndex;
                    bestSeqSum = currentSum;
                    bestSampleIndex = i;
                }
                else if (currentBestLength == bestSeqLength &&
                         currentBestIndex == bestSeqIndex &&
                         currentSum > bestSeqSum)
                {
                    bestSeqLength = currentLength;
                    bestSeqIndex = currentBestIndex;
                    bestSeqSum = currentSum;
                    bestSampleIndex = i;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex + 1} with sum: {bestSeqSum}.\n" +
                              $"{string.Join(' ', samples[bestSampleIndex])}");
        }
    }
}