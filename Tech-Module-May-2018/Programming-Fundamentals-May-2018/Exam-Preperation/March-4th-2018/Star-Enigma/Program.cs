using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        public static char[] keyChars =  {'s', 't', 'a', 'r'}; 
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // message amount
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            List<string> decryptedMessages = new List<string>();
            Regex regex = new Regex(@"[^@\-!:>]*@(?<planet>[A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(\d+)");
            DecryptMessage(n,decryptedMessages);
            foreach (var decryptedMessage in decryptedMessages)
            {
                if (regex.Match(decryptedMessage).Success)
                {
                    string planet = regex.Match(decryptedMessage).Groups["planet"].Value;
                    string type = regex.Match(decryptedMessage).Groups["type"].Value;
                    switch (type)
                    {
                           case "A":
                               attackedPlanets.Add(planet);
                               break;
                           case "D":
                               destroyedPlanets.Add(planet);
                               break;
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var attackedPlanet in attackedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {attackedPlanet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var destroyedPlanet in destroyedPlanets.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {destroyedPlanet}");
            }
        }

        public static void DecryptMessage(int n, List<string> decryptedMessages)
        {
            for (int i = 1; i <= n; i++) // start reading each message
            {
                string input = Console.ReadLine();
                int decryptionKey = input.Count(x => keyChars.Contains(char.ToLower(x)));
                StringBuilder sb = new StringBuilder(input.Length);
                foreach (char character in input) // decrypt message
                {
                    char decryptedChar = (char)(character - decryptionKey);
                    sb.Append(decryptedChar);
                }
                decryptedMessages.Add(sb.ToString());
            }
        }
    }
}
