using System;
using System.Text.RegularExpressions;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {

            string topSurface = Console.ReadLine();
            string topMantle = Console.ReadLine();
            string middle = Console.ReadLine();
            string bottomMantle = Console.ReadLine();
            string bottomSurface = Console.ReadLine();
            string[] elements =
            {
                topSurface,
                topMantle,
                middle,
                bottomMantle,
                bottomSurface
            };
            Console.WriteLine(IsValidSnowflake(elements));
        }   

        public static string IsValidSnowflake(string[] elements)
        {
            string surfacePattern = @"^([^A-Za-z0-9]+)";
            string mantlePattern = @"^([0-9_]+)";
            string middlePattern = @"([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)";
            int coreLength = 0;
            bool isValid = true;
            for (int i = 0; i < elements.Length; i++)
            {
                switch (i)
                {
                    case 0:
                    case 4:
                        if (!Regex.Match(elements[i], surfacePattern).Success) // if it isn't a valid surface pattern -> false
                        {
                            isValid = false;
                        }
                        break;
                    case 1:
                    case 3:
                        if (!Regex.Match(elements[i], mantlePattern).Success) // if it isn't a valid mantle pattern -> false
                        {
                            isValid = false;
                        }
                        break;
                    case 2:
                        if (!Regex.Match(elements[i], middlePattern).Success) // if it isn't a valid surface pattern -> false
                        {
                            isValid = false;
                        }
                        else
                        {
                            coreLength = Regex.Match(elements[i], middlePattern).Groups["core"].Value.Length;
                        }
                        break;
                }
            }

            return isValid ? $"Valid\n{coreLength}" : "Invalid";
        }
    }
}
