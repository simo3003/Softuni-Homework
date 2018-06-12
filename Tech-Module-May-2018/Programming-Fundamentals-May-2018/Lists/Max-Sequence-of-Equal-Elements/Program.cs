using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int len = 1;
            int startIndex = 0;
            int bestStartIndex = 0;
            int bestLen = 1;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    len++;
                }
                else
                {
                    len = 1;
                    startIndex = i;
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStartIndex = startIndex;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(input[bestStartIndex+i] + " ");
            }
        }
    }
}
