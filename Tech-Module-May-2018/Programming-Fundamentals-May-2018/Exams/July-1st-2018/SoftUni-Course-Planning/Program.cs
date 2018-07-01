using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHEN INSERTING OUT OF RANGE?
            List<string> courses = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();
            while (input != "course start")
            {
                string[] splitInput = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = splitInput[0];
                switch (command)
                {
                    case "Add":
                        string toBeAdded = splitInput[1];
                        if (!courses.Contains(toBeAdded))
                        {
                            courses.Add(toBeAdded);
                        }
                        break;
                    case "Insert":
                        string toBeInserted = splitInput[1];
                        int index = int.Parse(splitInput[2]);
                        if (!courses.Contains(toBeInserted) && index >= 0 && index < courses.Count)
                        {
                            courses.Insert(index, toBeInserted);
                        }
                        else
                        {
                            //Random random = new Random();
                            //bool DONTLOOKATTHISCODE = (random.Next(0, 2) == 0)
                            //    ? false
                            //    : true;
                            //if (DONTLOOKATTHISCODE)
                            //{
                            //int tempIndex = courses.IndexOf(toBeInserted);
                            //courses.Remove(toBeInserted);
                            //courses.Insert(index, toBeInserted);
                            //}
                        }
                        break;
                    case "Remove":
                        string toBeRemoved = splitInput[1];
                        if (courses.Contains(toBeRemoved))
                        {
                            if (courses.Contains(toBeRemoved + "-Exercise"))
                            {
                                courses.Remove(toBeRemoved + "-Exercise");
                            }
                            courses.Remove(toBeRemoved);
                        }
                        break;
                    case "Swap":
                        string toBeSwapped1 = splitInput[1];
                        string toBeSwapped2 = splitInput[2];
                        if (courses.Contains(toBeSwapped1) && courses.Contains(toBeSwapped2))
                        {
                            int indexOfSwap;
                            if (courses.Contains(toBeSwapped1 + "-Exercise"))
                            {
                                indexOfSwap = courses.IndexOf(toBeSwapped1);
                                int indexOfSwap1 = courses.IndexOf(toBeSwapped2);
                                courses[indexOfSwap] = toBeSwapped2;
                                courses[indexOfSwap1] = toBeSwapped1;

                                indexOfSwap = courses.IndexOf(toBeSwapped1 + "-Exercise");
                                courses.RemoveAt(indexOfSwap);
                                indexOfSwap1 = courses.IndexOf(toBeSwapped1) + 1;
                                courses.Insert(indexOfSwap1, toBeSwapped2 + "-Exercise");
                                break;
                            }
                            if (courses.Contains(toBeSwapped2 + "-Exercise"))
                            {
                                indexOfSwap = courses.IndexOf(toBeSwapped1);
                                int indexOfSwap2 = courses.IndexOf(toBeSwapped2);
                                courses[indexOfSwap] = toBeSwapped2;
                                courses[indexOfSwap2] = toBeSwapped1;

                                indexOfSwap = courses.IndexOf(toBeSwapped2 + "-Exercise");
                                courses.RemoveAt(indexOfSwap);
                                indexOfSwap2 = courses.IndexOf(toBeSwapped2) + 1;
                                courses.Insert(indexOfSwap2, toBeSwapped1 + "-Exercise");
                                break;
                            }
                            indexOfSwap = courses.IndexOf(toBeSwapped1);
                            int indexOfSwap3 = courses.IndexOf(toBeSwapped2);
                            courses[indexOfSwap] = toBeSwapped2;
                            courses[indexOfSwap3] = toBeSwapped1;
                        }
                        break;
                    case "Exercise":
                        string toBeExercised = splitInput[1];
                        int indexOfExercise;
                        if (courses.Contains(toBeExercised))
                        {
                            indexOfExercise = courses.IndexOf(toBeExercised);
                            courses.Insert(indexOfExercise + 1, toBeExercised + "-Exercise");
                        }
                        else
                        {
                            courses.Add(toBeExercised);
                            courses.Add(toBeExercised + "-Exercise");
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}
