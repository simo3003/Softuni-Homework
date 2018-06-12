using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = ReverseDigits(numbers[i]);
            }

            Console.WriteLine(numbers.Sum());
        }

        private static int ReverseDigits(int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = reversedNumber * 10 + number % 10;
                number /= 10;
            }
            return reversedNumber;
        }
    }
}
