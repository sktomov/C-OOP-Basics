
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var numberOfEngines = int.Parse(Console.ReadLine());
		List<Engine> engines = new List<Engine>();
		AddEngines(numberOfEngines, engines);
		List<Car> cars = new List<Car>();
		var numberOfCars = int.Parse(Console.ReadLine());
		AddCars(engines, cars, numberOfCars);

		foreach (var car in cars)
		{
			Console.WriteLine($"{car.Model}:");
			Console.WriteLine($"  {car.Engine.Model}:");
			Console.WriteLine($"    Power: {car.Engine.Power}");
			Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
			Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
			Console.WriteLine($"  Weight: {car.Weight}");
			Console.WriteLine($"  Color: {car.Color}");

		}
	}

	private static void AddCars(List<Engine> engines, List<Car> cars, int numberOfCars)
	{
		for (int i = 0; i < numberOfCars; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var engineModel = inputLine[1];
			var engine = engines.FirstOrDefault(e => e.Model == engineModel);
			var car = new Car(inputLine[0], engine);
			if (inputLine.Length > 2)
			{
				if (inputLine.Length == 3)
				{
					double toCheck = 0;
					var isDigit = double.TryParse(inputLine[2], out toCheck);
					if (isDigit)
					{
						car.Weight = inputLine[2];
					}
					else
					{
						car.Color = inputLine[2];
					}
				}
				else
				{
					car.Weight = inputLine[2];
					car.Color = inputLine[3];
				}
			}
			cars.Add(car);
		}
	}

	private static void AddEngines(int numberOfEngines, List<Engine> engines)
	{
		for (int i = 0; i < numberOfEngines; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var engine = new Engine(inputLine[0], inputLine[1]);
			if (inputLine.Length > 2)
			{
				if (inputLine.Length == 3)
				{
					double toCheck = 0;
					var isDigit = double.TryParse(inputLine[2], out toCheck);
					if (isDigit)
					{
						engine.Displacement = inputLine[2];
					}
					else
					{
						engine.Efficiency = inputLine[2];
					}
				}
				else
				{
					engine.Displacement = inputLine[2];
					engine.Efficiency = inputLine[3];
				}
			}
			engines.Add(engine);
		}
	}
}

