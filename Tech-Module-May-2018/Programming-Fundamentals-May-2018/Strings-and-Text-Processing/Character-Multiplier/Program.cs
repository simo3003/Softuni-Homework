using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(MultiplyCharCodeValues(input));
        }

        private static long MultiplyCharCodeValues(string[] input)
        {
            long sum = 0;
            if (input[0].Length > input[1].Length) // if the 1st string is longer
            {
                for (int i = 0; i < input[1].Length; i++) // for loop until the shorter one's length is reached
                {
                    sum += input[0][i] * input[1][i];
                }

                for (int i = input[1].Length; i < input[0].Length; i++) // add the rest of the char values
                {
                    sum += input[0][i];
                }
                return sum;
            }
            if (input[1].Length > input[0].Length) // if the 2nd string is longer
            {
                for (int i = 0; i < input[0].Length; i++) // for loop until the shorter one's length is reached
                {
                    sum += input[0][i] * input[1][i];
                }

                for (int i = input[0].Length; i < input[1].Length; i++) // add the rest of the char values
                {
                    sum += input[1][i];
                }
                return sum;
            }
            else // if the strings are of equal length
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += input[0][i] * input[1][i];
                }
                return sum;
            }
        }
    }
}
