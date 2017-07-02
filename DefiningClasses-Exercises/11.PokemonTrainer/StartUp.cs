
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
		while (inputLine[0] != "Tournament")
		{
			var trainerName = inputLine[0];
			var pokemonName = inputLine[1];
			var pokemonElement = inputLine[2];
			var pokemonHealth = double.Parse(inputLine[3]);
			var pokemon = new Pokemon()
			{
				Name = pokemonName,
				Element = pokemonElement,
				Health = pokemonHealth
			};
			if (!trainers.ContainsKey(trainerName))
			{
				var trainer = new Trainer()
				{
					Name = trainerName
				};
				trainers[trainerName] = trainer;
			}
			trainers[trainerName].Pokemons.Add(pokemon);

			inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}
		var elements = Console.ReadLine();
		while (elements != "End")
		{
			foreach (var trainer in trainers.Values)
			{
				if (trainer.Pokemons.Any(p => p.Element == elements))
				{
					trainer.Badges++;
				}
				else
				{
					foreach (var pokemon in trainer.Pokemons)
					{
						pokemon.Health -= 10;
					}
					trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
				}
			}

			elements = Console.ReadLine();
		}
		
		
		foreach (var trainer in trainers.Values.OrderByDescending(t => t.Badges))
		{
			Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
		}
	}
}

