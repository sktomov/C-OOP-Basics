
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		//•	If you receive a command to add a player to a missing team, print "Team [team name] does not exist."
		//•	If you receive a command to show stats for a missing team, print "Team [team name] does not exist."
		var inputLine = Console.ReadLine().Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
		var teams = new HashSet<Team>();
		while (inputLine[0].ToLower() != "end")
		{
			try
			{
				switch (inputLine[0].ToLower())
				{
					case "team":
						var team = new Team(inputLine[1]);
						teams.Add(team);
						break;
					case "add":
						AddingPlayers(teams, inputLine);
						break;
					case "remove":
						RemovePlayer(teams, inputLine);
						break;
					case "rating":
						PrintTeamRating(teams, inputLine[1]);
						break;
					default:
						break;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			

			inputLine = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		}

	}

	private static void PrintTeamRating(HashSet<Team> teams, string teamName)
	{
		var team = teams.FirstOrDefault(t => t.Name == teamName);
		if (team == null)
		{
			Console.WriteLine($"Team {teamName} does not exist.");
			return;
		}
		Console.WriteLine($"{team.Name} - {team.GetRating()}");
	}

	private static void RemovePlayer(HashSet<Team> teams, string[] inputLine)
	{
		var team = teams.FirstOrDefault(t => t.Name == inputLine[1]);
		if(team == null)
		{
			Console.WriteLine($"Team {inputLine[1]} does not exist.");
			return;
		}
		team.RemovePlayer(inputLine[2]);
	}

	private static void AddingPlayers(HashSet<Team> teams, string[] inputLine)
	{
		var team = teams.FirstOrDefault(t => t.Name == inputLine[1]);
		if (team == null)
		{
			Console.WriteLine($"Team {inputLine[1]} does not exist.");
			return;
		}
		//Add;Arsenal;Kieran_Gibbs;75;85;84;92;67
		var player = new Player(inputLine[2], double.Parse(inputLine[3]), double.Parse(inputLine[4]), double.Parse(inputLine[5]), double.Parse(inputLine[6]), double.Parse(inputLine[7]));
		team.AddPlayer(player);
	}
}

