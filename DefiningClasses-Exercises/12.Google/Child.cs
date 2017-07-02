
public class Child
{
	//•	“<Name> children <childName> <childBirthday>”

	public string Name { get; set; }

	public string BirthDay { get; set; }
	public override string ToString()
	{
		return $"{this.Name} {this.BirthDay}";
	}
}

