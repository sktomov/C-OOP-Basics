
using System;
using System.Collections.Generic;

public class StartUp
{
	public static void Main()
	{
		var info = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		try
		{
			while (info[0] != "END")
			{
				switch (info[0].ToLower())
				{
					case "pizza":
						PrintPizza(info[1], int.Parse(info[2]));
						break;
					case "dough":
						var dough = new Dough()
						{
							DoughType = info[1],
							BakingTechnique = info[2],
							Weight = double.Parse(info[3])
						};
						Console.WriteLine($"{dough.Calories():f2}");
						break;
					case "topping":
						var topping = new Topping()
						{
							Type = info[1],
							Weight = double.Parse(info[2])
						};
						Console.WriteLine($"{topping.Calories():f2}");
						break;
				}
				info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			}

		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			
		}
	}

	private static void PrintPizza(string name, int toppingCount)
	{
		var pizza = new Pizza(name, toppingCount);
		var doughInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		var dough = new Dough()
		{
			DoughType = doughInfo[1],
			BakingTechnique = doughInfo[2],
			Weight = double.Parse(doughInfo[3])
		};
		pizza.Dough = dough;
		for (int i = 0; i < toppingCount; i++)
		{
			var toppingInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var topping = new Topping()
			{
				Type = toppingInfo[1],
				Weight = double.Parse(toppingInfo[2])
			};
			pizza.Toppings.Add(topping);
		}

		Console.WriteLine($"{pizza.Name} - {pizza.CalculateCalories():f2} Calories.");
	}
}

