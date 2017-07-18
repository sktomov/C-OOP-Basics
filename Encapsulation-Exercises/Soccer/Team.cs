
using System;
using System.Collections.Generic;
using System.Linq;

public class Team
{
	//and methods for adding and removing players.
	private string name;
	private int rating;

	public Team(string name)
	{
		this.Name = name;
		this.Players = new HashSet<Player>();
	}

	public string Name
	{
		get { return this.name; }
		set
		{
			if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("A name should not be empty.");
			}
			this.name = value;
		}
	}

	public HashSet<Player> Players { get; set; }

	public double GetRating()
	{
		if (this.Players.Count > 0)
		{
			return Math.Round(this.Players.Select(p => p.OverallSkill()).Average());
		}
		else
		{
			return 0;
		}
	}

	public void AddPlayer(Player player)
	{
		this.Players.Add(player);
	}

	public void RemovePlayer(string playerName)
	{
		var player = Players.FirstOrDefault(p => p.Name == playerName);
		if (player == null)
		{
			throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
		}
		else
		{
			Players.Remove(player);
		}
	}
}

