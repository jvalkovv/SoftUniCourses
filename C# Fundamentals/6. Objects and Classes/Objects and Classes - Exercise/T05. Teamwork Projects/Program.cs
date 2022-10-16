using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T05._Teamwork_Projects
{
    internal class Program
    {
        class Team
        {
            public Team (string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                this.Members = new List<string>();
            }
            public string Name { get; set; }
            public string Creator { get; set; }

            public List<string> Members { get; set; }

            public void AddMembers(string member)
            {
                this.Members.Add(member);
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{this.Name}");
                sb.AppendLine($"- {this.Creator}");

                foreach (string currMember in this.Members.OrderBy(m => m))
                {
                    sb.AppendLine($"-- {currMember}");
                }
                return sb.ToString().TrimEnd();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= n; i++)
            {
                string[] teamArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creatorName = teamArgs[0];
                string teamName = teamArgs[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = joinArgs[0];
                string teamName = joinArgs[1];

                Team surchedTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (surchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");

                    continue;
                }
                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");

                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");

                    continue;
                }

                surchedTeam.AddMembers(memberName);

            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            List<Team> nonValidTeams = teams.Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            PrintValidTeams(validTeams);
            PrintInvalidTeams(nonValidTeams);

        }
        static void PrintInvalidTeams(List<Team> invalidTeams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in invalidTeams)
            {
                Console.WriteLine($"{invalidTeam.Name}");
            }
        }
        static void PrintValidTeams(List<Team> validTeams)
        {
            foreach (Team validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.Name}");
                Console.WriteLine($"- {validTeam.Creator}");
                foreach (string currMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currMember}");
                }
            }
        }
    }
}