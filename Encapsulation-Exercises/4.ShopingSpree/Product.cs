
using System;

public class Product
{
	private string name;
	private decimal cost;


	public decimal Cost
	{
		get { return this.cost; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Money cannot be negative");
			}
			this.cost = value;
		}
	}
	public string Name
	{
		get { return this.name; }
		set
		{
			if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
			{
				throw new ArgumentException("Name cannot be empty");
			}
			this.name = value;
		}
	}
}

