
using System;

public class Dough
{
	private string doughType;
	private string bakingTechnique;
	private double weight;

	public string DoughType
	{
		get { return this.doughType; }
		set
		{
			if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
			{
				this.doughType = value;
			}
			else
			{
				throw new ArgumentException("Invalid type of dough.");
			}
		}
	}
	public string BakingTechnique
	{
		get { return this.bakingTechnique; }
		set
		{
			if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
			{
				this.bakingTechnique = value;
			}
			else
			{
				throw new ArgumentException("Invalid type of dough.");
			}
		}
	}

	public double Weight
	{
		get { return this.weight; }
		set
		{
			if (value < 1 || value > 200)
			{
				throw new ArgumentException("Dough weight should be in the range [1..200].");
			}
			this.weight = value;
		}
		
	}

	
	public double Calories()
	{
		double doughTypeValue = 0;
		double backingValue = 0;
		if (this.doughType.ToLower() == "white")
		{
			doughTypeValue = 1.5;
		}
		if(this.doughType.ToLower() == "wholegrain")
		{
			doughTypeValue = 1;
		}

		if (this.bakingTechnique.ToLower() == "crispy")
		{
			backingValue = 0.9;
		}
		if (this.bakingTechnique.ToLower() == "chewy")
		{
			backingValue = 1.1;
		}
		if (this.bakingTechnique.ToLower() == "homemade")
		{
			backingValue = 1;
		}

		return 2 * this.weight * doughTypeValue * backingValue;
	}
}

