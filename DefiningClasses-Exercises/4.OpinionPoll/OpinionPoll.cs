
using System;
using System.Collections.Generic;
using System.Linq;

public class OpinionPoll
{
	public static void Main()
	{
		var numberOfPersons = int.Parse(Console.ReadLine());
		List<Person> people = new List<Person>();
		for (int i = 0; i < numberOfPersons; i++)
		{
			var inputLine = Console.ReadLine().Split();
			string name = inputLine[0];
			int age = int.Parse(inputLine[1]);
			Person person = new Person()
			{
				Name = name,
				Age = age
			};
			people.Add(person);
		}
		var result = Result(people);
		foreach (var person in result)
		{
			Console.WriteLine($"{person.Name} - {person.Age}");
		}
	}
	public static List<Person> Result(List<Person> people)
	{
		return people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
	}
}

