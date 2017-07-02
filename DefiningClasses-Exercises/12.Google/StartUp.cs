
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		var people = new List<Person>();
		while (inputLine[0] != "End")
		{
			switch (inputLine[1])
			{
				case "company":
					AddCompany(people, inputLine);
					break;
				case "pokemon":
					AddPokemons(people, inputLine);
					break;
				case "parents":
					AddParents(people, inputLine);
					break;
				case "children":
					Children(people, inputLine);
					break;
				case "car":
					AddCar(people, inputLine);
					break;

			}

			inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}

		var personInfo = Console.ReadLine().Trim();
		var person = people.FirstOrDefault(p => p.Name == personInfo);
		if (person != null)
		{
			Console.WriteLine(personInfo);
			Console.WriteLine($"Company:");
			if (person.Company != null)
			{
				Console.WriteLine(person.Company.ToString());
			}
			Console.WriteLine("Car:");
			if (person.Car != null)
			{
				Console.WriteLine(person.Car.ToString());
			}
			Console.WriteLine("Pokemon:");
			if (person.Pokemons.Count > 0)
			{
				foreach (var pokemon in person.Pokemons)
				{
					Console.WriteLine(pokemon.ToString());
				}
			}
			Console.WriteLine("Parents:");
			if (person.Parents.Count > 0)
			{
				foreach (var parent in person.Parents)
				{
					Console.WriteLine(parent.ToString());
				}
			}
			Console.WriteLine("Children:");
			if (person.Children.Count > 0)
			{
				foreach (var child in person.Children)
				{
					Console.WriteLine(child.ToString());
				}
			}
		}
	}

	private static void AddCar(List<Person> people, string[] inputLine)
	{
		var personName = inputLine[0];
		var carModel = inputLine[2];
		var speed = inputLine[3];
		

		var car = new Car()
		{
			Model = carModel,
			Speed = speed
		};

		var person = people.FirstOrDefault(p => p.Name == personName);
		if (person == null)
		{
			var personToAdd = new Person()
			{
				Name = personName
			};

			personToAdd.Car = car;
			people.Add(personToAdd);
		}
		else
		{
			person.Car = car;
		}
	}

	private static void Children(List<Person> people, string[] inputLine)
	{
		var personName = inputLine[0];
		var childName = inputLine[2];
		var childBithDay = inputLine[3];


		var child = new Child()
		{
			Name = childName,
			BirthDay = childBithDay
		};

		var person = people.FirstOrDefault(p => p.Name == personName);
		if (person == null)
		{
			var personToAdd = new Person()
			{
				Name = personName
			};

			personToAdd.Children.Add(child);
			people.Add(personToAdd);
		}
		else
		{
			person.Children.Add(child);
		}
	}

	private static void AddParents(List<Person> people, string[] inputLine)
	{
		var personName = inputLine[0];
		var parentName = inputLine[2];
		var parentBirhtDay = inputLine[3];


		var parent = new Parent()
		{
			Name = parentName,
			BirthDay = parentBirhtDay
		};

		var person = people.FirstOrDefault(p => p.Name == personName);
		if (person == null)
		{
			var personToAdd = new Person()
			{
				Name = personName
			};

			personToAdd.Parents.Add(parent);
			people.Add(personToAdd);
		}
		else
		{
			person.Parents.Add(parent);
		}
	}

	private static void AddPokemons(List<Person> people, string[] inputLine)
	{
		var personName = inputLine[0];
		var pokemonName = inputLine[2];
		var pokemonType = inputLine[3];
		

		var pokemon = new Pokemon()
		{
			Name = pokemonName,
			Type = pokemonType
		};

		var person = people.FirstOrDefault(p => p.Name == personName);
		if (person == null)
		{
			var personToAdd = new Person()
			{
				Name = personName
			};

			personToAdd.Pokemons.Add(pokemon);
			people.Add(personToAdd);
		}
		else
		{
			person.Pokemons.Add(pokemon); 
		}
	}

	private static void AddCompany(List<Person> people, string[] inputLine)
	{
		var personName = inputLine[0];
		var companyName = inputLine[2];
		var department = inputLine[3];
		var salary = double.Parse(inputLine[4]);

		var company = new Company()
		{
			Name = companyName,
			Department = department,
			Salary = salary
		};

		var person = people.FirstOrDefault(p => p.Name == personName);
		if (person == null)
		{
			var personToAdd = new Person()
			{
				Name = personName
			};
			
			personToAdd.Company = company;
			people.Add(personToAdd);
		}
		else
		{
			person.Company = company;
		}
	}
}

