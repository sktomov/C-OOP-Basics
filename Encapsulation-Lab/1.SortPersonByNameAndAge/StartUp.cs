
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		int lines = int.Parse(Console.ReadLine());
		var people = new List<Person>();
		for (int i = 0; i < lines; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var person = new Person(inputLine[0], inputLine[1], int.Parse(inputLine[2]));
			people.Add(person);
		}
		people.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList().ForEach(p => Console.WriteLine(p.ToString()));
	}
}

