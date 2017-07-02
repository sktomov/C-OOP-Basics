using System;
using System.Reflection;

public class StartUp
{
	static void Main()
	{
		Type personType = typeof(Person);
		ConstructorInfo emptyCtor = personType.GetConstructor(new Type[]{});
		ConstructorInfo ageCtor = personType.GetConstructor(new [] { typeof(int) });
		ConstructorInfo nameAgeCtor = personType.GetConstructor(new[] { typeof(string),typeof(int) });

		bool swaped = false;

		if (nameAgeCtor == null)
		{
			nameAgeCtor = personType.GetConstructor(new[] {typeof(int), typeof(string)});
			swaped = true;
		}
		string name = Console.ReadLine();
		int age = int.Parse(Console.ReadLine());

		Person basePerson = (Person) emptyCtor.Invoke(new object[] { });
		Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
		Person personWithAgeAndName = swaped
			? (Person) nameAgeCtor.Invoke(new object[] {age, name})
			: (Person) nameAgeCtor.Invoke(new object[] {name, age});
		Console.WriteLine($"{basePerson.name} {basePerson.age}");
		Console.WriteLine($"{personWithAge.name} {personWithAge.age}");
		Console.WriteLine($"{personWithAgeAndName.name} {personWithAgeAndName.age}");
	}
}

