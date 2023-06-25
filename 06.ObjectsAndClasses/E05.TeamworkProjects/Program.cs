using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int teamCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < teamCount; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creator = input[0];
                string teamName = input[1];
                Team team = new Team(creator, teamName);
                if (teams.FirstOrDefault(x => x.TeamName == teamName) == null)
                {
                    if (teams.FirstOrDefault(x => x.Creator == creator) == null)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string userInput = "";
            while ((userInput = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = userInput.Split("->");
                string user = tokens[0];
                string teamToJoin = tokens[1];
                int foundTeam = teams.FindIndex(x => x.TeamName == teamToJoin);
                if (foundTeam < 0)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }

                Team teamWithExistingMember = teams.Find(team => team.TeamMembers.Contains(user));
                if (teamWithExistingMember != null || teams[foundTeam].Creator == user)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    continue;
                }
                else
                {
                    teams[foundTeam].TeamMembers.Add(user);
                }
            }

            List<Team> validTeams = teams.FindAll(team => team.TeamMembers.Count > 0);
            List<Team> disbanded = teams.FindAll(team => team.TeamMembers.Count == 0);

            foreach (Team team in validTeams.OrderByDescending(name => name.TeamMembers.Count).ThenBy(s => s.TeamName))
            {
                Console.WriteLine(team.Print());
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbanded.OrderBy(name => name.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
    public class Team
    {
        public Team(string creator, string teamName)
        {
            TeamName = teamName;
            Creator = creator;
            TeamMembers = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> TeamMembers { get; set; }

        public string Print()
        {
            TeamMembers.Sort();
            string result = TeamName + "\n";
            result += $"- {Creator}\n";
            foreach (string member in TeamMembers)
            {
                result += $"-- {member}\n";
            }

            return result.Trim();
        }
    }
}
/*
2
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment

3
Tanya-CloneClub
Helena-CloneClub
Tedy-SoftUni
George->softUni
George->SoftUni
Tatyana->Leda
John->SoftUni
Cossima->CloneClub
end of assignment
*/