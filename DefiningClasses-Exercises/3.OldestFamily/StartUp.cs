
using System;
using System.Reflection;

public class StartUp
{
	static void Main()
	{
		var numberOfPersons = int.Parse(Console.ReadLine());
		Family family = new Family();
		for (int i = 0; i < numberOfPersons; i++)
		{
			var inputLine = Console.ReadLine().Split();
			string name = inputLine[0];
			int age = int.Parse(inputLine[1]);
			Person person = new Person(name, age);
			family.AddMember(person);
		}
		var oldest = family.GetOldestMember();
		//Console.Clear();
		if (oldest != null)
		{
			Console.WriteLine($"{oldest.name} {oldest.age}");
		}

	}
}

