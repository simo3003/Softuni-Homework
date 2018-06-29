using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> games = new List<string>();
            games = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (input != "Play!")
            {
                string game = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                if (input.StartsWith("Install"))
                {
                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if (input.StartsWith("Uninstall"))
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                    }
                }
                else if (input.StartsWith("Update"))
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (input.StartsWith("Expansion"))
                {
                    string expansion = game.Split('-')[1];
                    game = game.Split('-')[0];
                    if (games.Contains(game))
                    {
                        games.Insert(games.IndexOf(game) + 1, game + ":" + expansion);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", games));
        }
    }
}
