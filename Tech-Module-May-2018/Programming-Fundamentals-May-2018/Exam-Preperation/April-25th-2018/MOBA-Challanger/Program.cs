using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Challanger
{
    class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Skill { get; set; }
        public int TotalSkill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Player> playerPool = new List<Player>();
            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] playerInfo = String.Join("", input
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
                        .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    Player player = new Player
                    {
                        Name = playerInfo[0],
                        Position = playerInfo[1],
                        Skill = int.Parse(playerInfo[2])
                    };
                    if (!playerPool.Any(x => x.Name == player.Name))
                    {
                        playerPool.Add(player);
                    }
                    else if (playerPool.Where(x => x.Name == player.Name).ToList().Last().Skill <= player.Skill)
                    {
                        playerPool.Add(player);
                    }
                }
                else
                {
                    string player1 = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                    string player2 = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2];
                    bool posMatch = false;
                    foreach (var position in playerPool.Where(x => x.Name == player1).Select(x => x.Position))
                    {
                        foreach (var position2 in playerPool.Where(x => x.Name == player2).Select(x => x.Position))
                        {
                            if (position == position2)
                            {
                                posMatch = true;
                                break;
                            }
                        }
                    }
                    if (posMatch)
                    {
                        if ((playerPool.Where(x => x.Name == player1).Select(x => x.Skill).Sum()) >= (playerPool.Where(x => x.Name == player1).Select(x => x.Skill).Sum()))
                        {
                            playerPool.RemoveAll(x => x.Name == player2);
                        }
                        else if ((playerPool.Where(x => x.Name == player1).Select(x => x.Skill).Sum()) <= (playerPool.Where(x => x.Name == player1).Select(x => x.Skill).Sum()))
                        {
                            playerPool.RemoveAll(x => x.Name == player1);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var player in playerPool)
            {
                player.TotalSkill = playerPool.Where(x => x.Name == player.Name).Select(x => x.Skill).Sum();
            }
            playerPool = playerPool.OrderByDescending(x => x.TotalSkill).ThenBy(y => y.Name).ToList();
            var tempList = new List<Player>(playerPool)
                            .GroupBy(x => x.Name)
                            .Select(y => y.First())
                            .ToList();
            foreach (var tempPlayer in tempList)
            {
                Console.WriteLine($"{tempPlayer.Name}: {tempPlayer.TotalSkill} skill");
                List<Player> currentPlayerInfo = new List<Player>();
                currentPlayerInfo = new List<Player>(playerPool).Where(x => x.Name == tempPlayer.Name).OrderByDescending(x => x.Skill).ThenBy(y => y.Position).ToList();
                foreach (var player in currentPlayerInfo)
                {
                    if (player.Name == tempPlayer.Name)
                    {
                        Console.WriteLine($"- {player.Position} <::> {player.Skill}");
                    }
                }
            }
        }
    }
}
