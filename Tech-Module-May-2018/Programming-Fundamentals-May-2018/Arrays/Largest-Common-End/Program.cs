using System;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] second = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rightMatchCount = 0;
            int leftMatchCount = 0;
            for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
            {
                if (first[i] == second[i])
                {
                    leftMatchCount++;
                }
            }
            Array.Reverse(first);
            Array.Reverse(second);
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[i] == second[i])
                {
                    rightMatchCount++;
                }
            }
            Console.WriteLine(Math.Max(rightMatchCount,leftMatchCount));
        }
    }
}
