public class Person
{
	public Person()
	{
		this.age = 1;
		this.name = "No name";
	}

	public Person(int age) : this()
	{
		this.age = age;
	}

	public Person(string name, int age)
	{
		this.age = age;
		this.name = name;
	}
	public string name;
	public int age;
}

