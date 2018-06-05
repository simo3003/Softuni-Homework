using System;
using System.Linq;
namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int masterKey = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {

                    if (input[j] - input[i] == masterKey || input[i] - input[j] == masterKey)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
