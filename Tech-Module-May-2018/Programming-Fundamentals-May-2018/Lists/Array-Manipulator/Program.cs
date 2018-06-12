using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "print")
            {
                List<string> parameters = command
                    .Split()
                    .ToList();
                switch (parameters[0])
                {
                    case "add":
                        input.Insert(int.Parse(parameters[1]), int.Parse(parameters[2]));
                        break;
                    case "addMany":
                        //List<int> elementsToAdd = parameters
                        //    .Skip(2)
                        //    .Select(int.Parse)
                        //    .ToList();
                        //input.InsertRange(int.Parse(parameters[1]), elementsToAdd);
                        int index = int.Parse(parameters[1]);
                        int elementsAmount = parameters.Skip(2).Count(); // skip the first 2 elements (1st one being the command, 2nd one being the index)
                        for (int i = 0; i < elementsAmount; i++)
                        {
                            input.Insert(i + index, int.Parse(parameters[2 + i]));
                        }
                        break;
                    case "contains":
                        if (input.Contains(int.Parse(parameters[1])))
                        {
                            Console.WriteLine(input.IndexOf(int.Parse(parameters[1])));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        input.RemoveAt(int.Parse(parameters[1]));
                        break;
                    case "shift":
                        int counter = 0;
                        int amountOfShifts = int.Parse(parameters[1]);
                        while (counter < amountOfShifts)
                        {
                            LeftShift(input);
                            counter++;
                        }
                        break;
                    case "sumPairs":
                        List<int> modifiedInput = new List<int>();
                        for (int i = 0; i < input.Count; i += 2)
                        {
                            if (i == input.Count - 1)
                            {
                                modifiedInput.Add(input[i]);
                            }
                            else
                            {
                                modifiedInput.Add(input[i] + input[i + 1]);
                            }
                        }
                        input = modifiedInput;
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }
        private static void LeftShift(List<int> numbers)
        {

            int firstElement = numbers[0]; // get the first element
            for (int j = 0; j < numbers.Count-1; j++) // loop from the first index to the last index
            {
                numbers[j] = numbers[j+1];
            }
            numbers[numbers.Count - 1] = firstElement;
        }
    }
}
