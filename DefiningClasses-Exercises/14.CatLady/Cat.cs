
using System.Text;

public class Cat
{
	public Cat(string breed, string name)
	{
		this.Breed = breed;
		this.Name = name;
		this.Decibels = null;
		this.FurLenght = null;
		this.EarSize = null;
	}
	public string Name { get; set; }

	public string Breed { get; set; }

	public int? EarSize { get; set; }

	public double? FurLenght { get; set; }

	public int? Decibels { get; set; }

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append($"{this.Breed} {this.Name} ");
		if (this.EarSize != null)
		{
			sb.Append($"{this.EarSize}");
		}
		if (this.Decibels != null)
		{
			sb.Append($"{this.Decibels}");
		}
		if (this.FurLenght != null)
		{
			sb.Append($"{this.FurLenght:f2}");
		}

		return sb.ToString();
	}
}

