using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int matchIndex = -1;
            int leftSum = 0;
            int rightSum = input.Sum(); // get total sum of the array
            for (int i = 0; i < input.Length; i++)
            {
                rightSum -= input[i]; // move the current number (from the rightSum to the leftSum)
                if (rightSum == leftSum) // compare the sum
                {
                    matchIndex = i;
                    break;
                }
                leftSum += input[i]; // add the current number 
            }
            if (matchIndex == -1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(matchIndex);
            }
        }
    }
}
