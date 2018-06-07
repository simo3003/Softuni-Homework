using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "Odd" && command != "Even")
            {
                string[] parameters = command.Split(" ");
                switch (parameters[0])
                {
                    case "Delete":
                        input.RemoveAll(x => x == int.Parse(parameters[1]));
                        break;
                    case "Insert":
                        input.Insert(int.Parse(parameters[2]), int.Parse(parameters[1]));
                        break;
                }
                command = Console.ReadLine();
            }

            string output = (command == "Odd")
                ? string.Join(" ", input.Where(x => x % 2 != 0))
                : string.Join(" ", input.Where(x => x % 2 == 0));
            Console.WriteLine(output);
        }
    }
}
