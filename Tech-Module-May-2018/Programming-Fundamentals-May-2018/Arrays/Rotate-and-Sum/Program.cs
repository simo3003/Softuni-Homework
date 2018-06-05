using System;
using System.Collections.Generic;
using System.Linq;
namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotationAmount = int.Parse(Console.ReadLine());
            List<int[]> sum = new List<int[]>();
            for (int i = 1; i <= rotationAmount; i++)
            {
                Shift(numbers);
                sum.Add(numbers.ToArray());
            }

            int[] finalSum = new int[numbers.Length];
            foreach (int[] arr in sum)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    finalSum[i] += arr[i];
                }
            }
            Console.WriteLine(String.Join(" ", finalSum));
        }

        private static void Shift(int[] numbers)
        {
            int last = numbers[numbers.Length - 1];
            for (int j = numbers.Length-1; j > 0; j--)
            {
                numbers[j] = numbers[j-1];
            }
            numbers[0] = last;
        }
    }
}
