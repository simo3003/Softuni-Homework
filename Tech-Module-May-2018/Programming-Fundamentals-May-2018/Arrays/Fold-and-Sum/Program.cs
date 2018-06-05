using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int k = input.Length / 4;
            int[] topRow = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                topRow[i] = input[k - 1 - i];
            }
            for (int i = 0; i < k; i++)
            {
                topRow[i + k] = input[input.Length - 1 - i];
            }
            int[] bottomRow = new int[2 * k];
            for (int i = k; i <= input.Length - 1 - k; i++)
            {
                bottomRow[i - k] = input[i];
            }
            for (int i = 0; i < topRow.Length; i++)
            {
                Console.Write($"{topRow[i] + bottomRow[i]} ");
            }
        }
    }
}
