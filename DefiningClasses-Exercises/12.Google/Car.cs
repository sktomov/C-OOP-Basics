
public class Car
{
	//•	“<Name> car <carModel> <carSpeed>”

	public string Model { get; set; }

	public string Speed { get; set; }
	public override string ToString()
	{
		return $"{this.Model} {this.Speed}";
	}
}

