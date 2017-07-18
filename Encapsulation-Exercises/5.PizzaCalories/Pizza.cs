
using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
	private string name;
	private int toppingCount;
	

	public Pizza(string name, int toppingCount)
	{
		this.Toppings = new List<Topping>();
		this.Name = name;
		this.ToppingCount = toppingCount;
	}

	public Pizza()
	{
		
	}
	public string Name
	{
		get { return this.name; }
		private set
		{
			if (string.IsNullOrEmpty(value) || value.Length > 15)
			{
				throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
			}
			this.name = value;
		}
	}
	public int ToppingCount
	{
		get { return this.toppingCount; }
		private set
		{
			if (value < 0 || value >10)
			{
				throw new ArgumentException("Number of toppings should be in range [0..10].");
			}
			this.toppingCount = value;
		}
	}

	public Dough Dough { get; set; }

	public List<Topping> Toppings { get; set; }
	
	public double CalculateCalories()
	{
		var a = this.Dough.Calories();
		var b = this.Toppings.Sum(t => t.Calories());
		return this.Dough.Calories() + this.Toppings.Sum(t => t.Calories());
	}
}

