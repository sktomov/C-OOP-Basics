
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var people = new List<Person>();
		var products = new List<Product>();

		var firstLine = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		var secondLine = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
		try
		{
			ReadPeople(people, firstLine);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			return;
		}
		try
		{
			ReadProducts(products, secondLine);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			return;

		}

		var cmd = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		while (cmd[0] != "END")
		{
			var person = people.FirstOrDefault(p => p.Name == cmd[0]);
			var product = products.FirstOrDefault(p => p.Name == cmd[1]);
			if (person != null && product != null)
			{
				if (person.Money >= product.Cost)
				{
					person.Money -= product.Cost;
					person.BagOfProducts.Add(product);
					Console.WriteLine($"{person.Name} bought {product.Name}");
				}
				else
				{
					Console.WriteLine($"{person.Name} can\'t afford {product.Name}");
				}
			}
			cmd = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}
		foreach (var person in people)
		{
			if (!person.BagOfProducts.Any())
			{
				Console.WriteLine($"{person.Name} - Nothing bought");
				continue;
			}

			Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(p => p.Name))}");
		}

	}

	private static void ReadProducts(List<Product> products, string[] secondLine)
	{
		foreach (var product in secondLine)
		{
			var firstProduct = new Product();
			var arr = product.Split(new[] {'='}, StringSplitOptions.RemoveEmptyEntries);
			var firstProductName = arr[0];
			var firstProductCost = decimal.Parse(arr[1]);
			firstProduct.Name = firstProductName;
			firstProduct.Cost = firstProductCost;
			products.Add(firstProduct);
		}
	}

	private static void ReadPeople(List<Person> people, string[] firstLine)
	{
		foreach (var personToTake in firstLine)
		{
			var person = new Person();
			var arr = personToTake.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
			var personName = arr[0];
			var personMoney = decimal.Parse(arr[1]);
			person.Name = personName;
			person.Money = personMoney;
			people.Add(person);
		}
	}
}

