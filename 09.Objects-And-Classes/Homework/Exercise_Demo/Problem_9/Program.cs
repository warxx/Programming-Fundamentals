using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();
            var signedUsers = new List<string>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split('-');

                var creator = input[0];
                var teamName = input[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Memebers = new List<string>();
                    team.Name = teamName;
                    team.Creator = creator;
                    teams.Add(team);
                    signedUsers.Add(creator);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var offfffffff = Console.ReadLine();

            while (offfffffff != "end of assignment")
            {
                var memberArgs = offfffffff.Split(new[] {'-', '>'}, StringSplitOptions.RemoveEmptyEntries);

                var memberName = memberArgs[0];
                var teamName = memberArgs[1];

                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (signedUsers.Contains(memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    var team = teams.FirstOrDefault(t => t.Name == teamName);
                    team.Memebers.Add(memberName);
                    signedUsers.Add(memberName);
                }

                offfffffff = Console.ReadLine();
            }

            foreach (var team in teams.Where(t => t.Memebers.Count > 0).OrderByDescending(t => t.Memebers.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Memebers.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (var team in teams.Where(t => t.Memebers.Count == 0).OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Memebers { get; set; }
    }
}
