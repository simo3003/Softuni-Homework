using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (input != "END")
            {
                string[] parameters = input.Split();
                switch (parameters[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(parameters[1]))
                        {
                            phonebook[parameters[1]] = parameters[2];
                        }
                        else
                        {
                            phonebook.Add(parameters[1], parameters[2]);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(parameters[1]))
                        {
                            Console.WriteLine($"{parameters[1]} -> {phonebook[parameters[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {parameters[1]} does not exist.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
