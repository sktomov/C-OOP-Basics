

public class Parent
{
	//•	“<Name> parents <parentName> <parentBirthday>”
	public string Name { get; set; }

	public string BirthDay { get; set; }
	public override string ToString()
	{
		return $"{this.Name} {this.BirthDay}";
	}
}

