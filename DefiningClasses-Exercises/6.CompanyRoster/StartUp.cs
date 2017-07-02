
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var numberOfEmployees = int.Parse(Console.ReadLine());
		var employees = new List<Employee>();

		for (int i = 0; i < numberOfEmployees; i++)
		{
			var inputLine = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

			var employee = new Employee(inputLine[0], decimal.Parse(inputLine[1]), inputLine[2], inputLine[3]);
			if (inputLine.Length > 4)
			{
				if (inputLine[4].Contains("@"))
				{
					employee.Email = inputLine[4];
				}
				else
				{
					employee.Age = int.Parse(inputLine[4]);
				}
			}
			if (inputLine.Length > 5)
			{
				employee.Age = int.Parse(inputLine[5]);
			}
			employees.Add(employee);
		}
		var result = employees.GroupBy(e => e.Department)
			.Select(e => new
			{
				Department = e.Key,
				Employees = e.OrderByDescending(emp => emp.Salary),
				AverageSalary = e.Average(emp => emp.Salary)
			}).OrderByDescending(e => e.AverageSalary)
			.FirstOrDefault();
		Console.WriteLine($"Highest Average Salary: {result.Department}");
		foreach (var employee in result.Employees)
		{
			Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
		}
	}
}

