using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();

                List<string> membersList = new List<string>();
                Team team = new Team
                {
                    TeamName = newTeam[1],
                    CreatorName = newTeam[0],
                    Members = membersList
                };
                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {newTeam[1]} has been created by {newTeam[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.CreatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }
            }

            string teamRegister = Console.ReadLine();

            while (!teamRegister.Equals("end of assignment"))
            {
                string[] split = teamRegister.Split(new char[] { '-', '>' }).ToArray();
                string newUser = split[0];
                string teamName = split[2];
                if (!teams.Select(x => x.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) || teams.Select(x => x.CreatorName).Contains(newUser))
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
                    teams[teamToJoinIndex].Members.Add(newUser);
                }

                teamRegister = Console.ReadLine();
            }

            IEnumerable<Team> teamsToDisband = teams.
                OrderBy(x => x.TeamName).
                Where(x => x.Members.Count == 0);
            IEnumerable<Team> fullTeams = teams.
            OrderByDescending(x => x.Members.Count).
            ThenBy(x => x.TeamName).
            Where(x => x.Members.Count > 0);

            foreach (Team team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }

        }
    }

}