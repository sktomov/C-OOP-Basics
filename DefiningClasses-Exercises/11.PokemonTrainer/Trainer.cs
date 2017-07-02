
using System.Collections.Generic;

public class Trainer
{
	//Trainers have a name, number of badges and a collection of pokemon. Every Trainer starts with 0 badges.
	public Trainer()
	{
		this.Badges = 0;
		this.Pokemons = new List<Pokemon>();
	}

	public string Name { get; set; }

	public int Badges { get; set; }

	public List<Pokemon> Pokemons { get; set; }
}

