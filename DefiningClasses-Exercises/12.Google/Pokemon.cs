
public class Pokemon
{
	//•	“<Name> pokemon <pokemonName> <pokemonType>”

	public string Name { get; set; }

	public string Type { get; set; }


	public override string ToString()
	{
		return $"{this.Name} {this.Type}";
	}
}

