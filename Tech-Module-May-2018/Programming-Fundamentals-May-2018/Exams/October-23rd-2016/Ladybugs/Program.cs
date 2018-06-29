using System;
using System.Collections.Generic;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldLength = int.Parse(Console.ReadLine());
            int[] field = new int[fieldLength];
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldLength)
                .ToList()
                .ForEach(x => field[x] = 1);
                
            string input = Console.ReadLine();
            while (input != "end") // End or end ???
            {
                string[] splitInput = input.Split();
                int index = int.Parse(splitInput[0]);
                string direction = splitInput[1];
                int amount = int.Parse(splitInput[2]);

                if (direction == "left")
                {
                    amount *= -1;
                }

                if (IsOutOfBounds(fieldLength, index) || field[index] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                field[index] = 0; // remove the ladybug from its current pos

                while (true) // run until it goes out of bounds (or steps on a free spot)
                {
                    index += amount;

                    if (IsOutOfBounds(fieldLength, index))
                    {
                        break;
                    }

                    if (field[index] == 0)
                    {
                        field[index] = 1;
                        break;
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",field));

        }
        private static bool IsOutOfBounds(int fieldLength, int index) => index < 0 || index >= fieldLength;

    }
}
