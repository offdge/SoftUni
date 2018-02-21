using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace FootballLeague
{
	class Program
	{
		public static void Main(string[] args)
		{
			var key = Regex.Escape(Console.ReadLine());
			var input = Console.ReadLine();
			var pattern = new Regex(string.Format(".*({0})(?<teamA>.*)({0}).*({0})(?<teamB>.*)({0}).*[^\\d+](?<teamAscore>\\d+):(?<teamBscore>\\d+)", key));
			var teams = new List<Team>();
			var counter = 1;
			
            while (input != "final")
            {
            	var regexMatch = pattern.Match(input);
            	
                if (regexMatch.Success)
                {
                    var teamAname = String.Join("",regexMatch.Groups["teamA"].Value.ToCharArray().Reverse().Select(x => x.ToString().ToUpper()).ToArray());
                    var teamBname = String.Join("",regexMatch.Groups["teamB"].Value.ToCharArray().Reverse().Select(x => x.ToString().ToUpper()).ToArray());
                    var teamAscore = int.Parse(regexMatch.Groups["teamAscore"].Value);
                    var teamBscore = int.Parse(regexMatch.Groups["teamBscore"].Value);
                    var teamApoints = 1;
                    var teamBpoints = 1;
                    var checkA = false;
					var checkB = false;
                    
                    if (teamAscore > teamBscore) 
                    {
                    	teamApoints = 3;
                    	teamBpoints = 0;
                    }
                    
                    if (teamAscore < teamBscore) 
                    {
                    	teamApoints = 0;
                    	teamBpoints = 3;
                    }
                    
                    var team1 = new Team { TeamName = teamAname, TeamScore = teamAscore, TeamPoints = teamApoints};
                    var team2 = new Team { TeamName = teamBname, TeamScore = teamBscore, TeamPoints = teamBpoints};
                    
                    foreach (var element in teams) 
                    {
			            if (element.TeamName == teamAname)
			            {
			            	element.TeamScore += teamAscore;
			            	element.TeamPoints += teamApoints;
			            	checkA = true;
			            }
			            
			            if (element.TeamName == teamBname)
			            {
			            	element.TeamScore += teamBscore;
			            	element.TeamPoints += teamBpoints;
			            	checkB = true;
			            }
                    }
                     
                    if (!checkA)	teams.Add(team1);
                    if (!checkB)	teams.Add(team2);
                }
                
                input = Console.ReadLine();
            }
            
            Console.WriteLine("League standings:");
            
            foreach (var team in teams.OrderByDescending(x => x.TeamPoints).ThenBy(x => x.TeamName))
            {
            	Console.WriteLine("{0}. {1} {2}", counter, team.TeamName,team.TeamPoints);
            	counter ++;
            }
            
            Console.WriteLine("Top 3 scored goals:");
            
            foreach (var team in teams.OrderByDescending(x => x.TeamScore).ThenBy(x => x.TeamName).Take(3))
            {
            	Console.WriteLine("- {0} -> {1}",team.TeamName,team.TeamScore);
            }
		}
	}
}

public class Team
{
    public string 	TeamName { get; set; }
    public int 		TeamScore { get; set; }
    public int 		TeamPoints { get; set; }
}