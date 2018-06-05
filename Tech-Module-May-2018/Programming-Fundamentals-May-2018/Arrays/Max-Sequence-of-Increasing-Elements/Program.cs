using System;
using System.Linq;
namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int len = 1;
            int bestLen = 1;
            int startIndex = 0;
            int bestStartIndex = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] - input[i-1] >=1 ) // if the "streak" doesn't end
                {
                    len++; // increase the "length" of the streak
                }
                else // otherwise restart the streak
                {
                    startIndex = i;
                    len = 1;
                }
                if (len > bestLen)
                {
                    bestStartIndex = startIndex;
                    bestLen = len;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write($"{input[i + bestStartIndex]} ");
            }
        }
    }
}
