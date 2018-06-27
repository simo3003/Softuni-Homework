using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //         side  -> members 
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                if (input.Contains(" | ")) // can the names contain | ?
                {
                    string[] splitInput = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = splitInput[0];
                    string forceUser = splitInput[1];
                    bool isUserInASide = false;
                    foreach (var side in database.Values.ToList())
                    {
                        if (side.Contains(forceUser)) // check if the user is in any of the sides
                        {
                            isUserInASide = true;
                        }                        
                    }

                    if (isUserInASide == false)
                    {
                        if (database.ContainsKey(forceSide))
                        {
                            database[forceSide].Add(forceUser);
                        }
                        else
                        {
                            database.Add(forceSide, new List<string>
                            {
                                forceUser    
                            });
                        }
                    }
                }
                else if (input.Contains(" -> ")) // can the names contain -> ?
                {
                    string[] splitInput = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = splitInput[0];
                    string forceSide = splitInput[1];
                    bool isUserInASide = false;
                    foreach (var side in database.Values.ToList())
                    {
                        if (side.Contains(forceUser)) // check if the user is in any of the sides
                        {
                            side.Remove(forceUser); // remove the user
                            if (database.ContainsKey(forceSide)) // check if the given side exists
                            {
                                if (!database[forceSide].Contains(forceUser)) // check if the user is in the side they want
                                {
                                    database[forceSide].Add(forceUser); // add them
                                }
                            }
                            else
                            {
                                database.Add(forceSide, new List<string>
                                {
                                    forceUser
                                });
                            }
                            isUserInASide = true;
                            break;
                        }                        
                    }

                    if (isUserInASide == false)
                    {
                        if (database.ContainsKey(forceSide))
                        {
                            database[forceSide].Add(forceUser);
                        }
                        else
                        {
                            database.Add(forceSide, new List<string>
                            {
                                forceUser    
                            });
                        }
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                input = Console.ReadLine();
            }

            foreach (var side in database.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (side.Value.Count>0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (var user in side.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}