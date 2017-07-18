
public class Person
{
	public Person(string firstName, string lastName, int age, double salary)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
		this.salary = salary;
	}
	private string firstName;
	private string lastName;
	private int age;
	private double salary;


	public string FirstName { get { return this.firstName; }  }
	public string LastName { get { return this.lastName; } }
	public int Age { get { return this.age; } }

	public override string ToString()
	{
		return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
	}

	public void IncreaseSalary(double bonus)
	{
		if (this.age > 30)
		{
			this.salary += this.salary * bonus / 100;
		}
		else
		{
			this.salary += this.salary * (bonus / 2) / 100;
		}
	}
}

