using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> userPoints = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissoins = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] splitInput = input.Split('-', StringSplitOptions.RemoveEmptyEntries);
                if (splitInput.Length == 3) // normal submission
                {
                    string username = splitInput[0];
                    string language = splitInput[1];
                    int points = int.Parse(splitInput[2]);
                    if (points < 0 || points > 100)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    if (userPoints.ContainsKey(username))
                    {
                        if (userPoints[username] < points)
                        {
                            userPoints[username] = points;
                        }
                    }
                    else
                    {
                        userPoints.Add(username, points);
                    }
                    if (languageSubmissoins.ContainsKey(language))
                    {
                        languageSubmissoins[language]++;
                    }
                    else
                    {
                        languageSubmissoins.Add(language, 1);
                    }

                }
                else if (splitInput.Length == 2 && splitInput[1] == "banned") // banning users
                {
                    string username = splitInput[0];
                    if (userPoints.ContainsKey(username))
                    {
                        userPoints.Remove(username);
                    }
                }
                input = Console.ReadLine();
            }
            if (userPoints.Count > 0)
            {
                Console.WriteLine("Results:");
                foreach (var user in userPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{user.Key} | {user.Value}");
                }
            }
            if (languageSubmissoins.Count > 0)
            {
                Console.WriteLine("Submissions:");
                foreach (var language in languageSubmissoins.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{language.Key} - {language.Value}");
                }
            }
            
        }
    }
}
