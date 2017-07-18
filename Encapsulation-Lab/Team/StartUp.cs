
using System;

public class StartUp
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		var team = new Team("Name");
		for (int i = 0; i < n; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var person = new Person(inputLine[0], inputLine[1], int.Parse(inputLine[2]), double.Parse(inputLine[3]));
			team.AddPlayer(person);
		}

		Console.WriteLine($"First team have {team.FirstTeam.Count} players");
		Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
	}
}

