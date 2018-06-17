using System;
using System.Collections.Generic;
using System.Linq;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // teamName -> Team -> {Creator, Members}
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string input;
            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine();
                string[] creatorAndTeam = input.Split('-');
                string userName = creatorAndTeam[0];
                string teamName = creatorAndTeam[1];
                if (teams.Keys.Contains(teamName)) // check if team has already been created
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Values.Select(x => x.Creator).Contains(userName))
                {
                    Console.WriteLine($"{userName} cannot create another team!");
                    continue;
                }
                teams[teamName] = new Team
                {
                    Creator = userName,
                    Members = new List<string>()
                };
                Console.WriteLine($"Team {teamName} has been created by {userName}!");
            }
            while (true)
            {
                input = Console.ReadLine();
                string[] memberAndTeam = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input == "end of assignment")
                {
                    break;
                }
                string userName = memberAndTeam[0];
                string teamName = memberAndTeam[1];
                if (!teams.ContainsKey(teamName)) // if the team does not exist
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Values.Select(x => x.Members).Any(x => x.Contains(userName)) ||
                    teams.Values.Select(x => x.Creator).Contains(userName))
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }
                teams[teamName].Members.Add(userName);
            }
            var correctTeams = teams
                .Where(t => t.Value.Members.Count > 0)
                .OrderByDescending(t => t.Value.Members.Count)
                .ThenBy(t => t.Key);
            foreach (var team in correctTeams)
            {
                Console.WriteLine($"{team.Key}");
                Console.WriteLine($"- {team.Value.Creator}");
                foreach (var member in team.Value.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            var teamsToDisband = teams
                .Where(t => t.Value.Members.Count == 0)
                .OrderBy(t => t.Key);
            Console.WriteLine($"Teams to disband:");
            foreach (var teamToDisband in teamsToDisband)
            {
                Console.WriteLine(teamToDisband.Key);
            }
        }
    }
    class Team
    {
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public Team()
        {
            Members = new List<string>();
        }
    }
}
