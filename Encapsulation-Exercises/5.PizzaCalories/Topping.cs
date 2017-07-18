using System;

public class Topping
{
	private string type;
	private double weight;

	public string Type
	{
		get { return this.type; }
		set
		{
			if (value.ToLower() == "meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce")
			{
				this.type = value;
			}
			else
			{
				throw new ArgumentException($"Cannot place {value} on top of your pizza.");
			}
		}
	}

	public double Weight
	{
		get { return this.weight; }
		set
		{
			if (value < 1 || value > 50)
			{
				throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
			}
			this.weight = value;
		}
	}

	public double Calories()
	{
		double typeValue = 0;
		if (this.type.ToLower() == "meat")
		{
			typeValue = 1.2;
		}
		if (this.type.ToLower() == "veggies")
		{
			typeValue = 0.8;
		}

		if (this.type.ToLower() == "cheese")
		{
			typeValue = 1.1;
		}
		if (this.type.ToLower() == "sauce")
		{
			typeValue = 0.9;
		}
		

		return 2 * this.weight * typeValue;
	}
}

