﻿
using System;
using System.Collections.Generic;

public class Person
{
	private string name;
	private decimal money;
	//private List<Product> bagOfProducts;
	public Person()
	{
		this.BagOfProducts = new List<Product>();
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

	public decimal Money
	{
		get { return this.money; }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Money cannot be negative");
			}
			this.money = value;
		}
	}

	public List<Product> BagOfProducts { get; set; }
}

