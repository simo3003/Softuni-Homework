using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            List<string> decodedStrings = new List<string>();
            string currentLine = Console.ReadLine();
            while (currentLine != "Visual Studio crash")
            {
                input.Add(currentLine);
                currentLine = Console.ReadLine();
            }
            int[] numbers = String.Join(" ", input)
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
            {
                if (numbers[currentNumber] == 32656 && numbers[currentNumber + 1] == 19759 && numbers[currentNumber + 2] == 32763)
                {
                    int stringSize = numbers[currentNumber + 4];
                    char[] decodedString = new char[stringSize];
                    for (int i = 0; i < stringSize; i++)
                    {
                        decodedString[i] = (char)numbers[currentNumber + 6 + i];
                    }
                    decodedStrings.Add(new string(decodedString));
                    currentNumber = currentNumber + 6 + stringSize;
                }
            }
            foreach (var decodedString in decodedStrings)
            {
                Console.WriteLine(decodedString);
            }
        }
    }
}
