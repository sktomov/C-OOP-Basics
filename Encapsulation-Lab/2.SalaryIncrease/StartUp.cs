
using System;
using System.Collections.Generic;


public class StartUp
{
	public static void Main()
	{
		int lines = int.Parse(Console.ReadLine());
		var people = new List<Person>();
		for (int i = 0; i < lines; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var person = new Person(inputLine[0], inputLine[1], int.Parse(inputLine[2]), double.Parse(inputLine[3]));
			people.Add(person);
		}
		var bonus = double.Parse(Console.ReadLine());
		people.ForEach(person => person.IncreaseSalary(bonus));
		people.ForEach(p => Console.WriteLine(p.ToString()));
	}
}

