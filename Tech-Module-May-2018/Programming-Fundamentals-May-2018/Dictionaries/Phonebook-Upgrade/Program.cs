using System;
using System.Collections.Generic;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
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
                    case "ListAll":
                        foreach (var phone in phonebook)
                        {
                            Console.WriteLine($"{phone.Key} -> {phone.Value}");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
