
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int numberOfCars = int.Parse(Console.ReadLine());
		Dictionary<string, Car> cars = new Dictionary<string, Car>();
		AddCars(numberOfCars, cars);

		var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

		while (inputLine[0] != "End")
		{
			var carModel = inputLine[1];
			var distance = double.Parse(inputLine[2]);
			if (cars.ContainsKey(carModel))
			{
				var fuelNeed = distance * cars[carModel].FuelConsumptionFor1km;
				if (cars[carModel].FuelAmount < fuelNeed)
				{
					Console.WriteLine("Insufficient fuel for the drive");
				}
				else
				{
					cars[carModel].FuelAmount -= fuelNeed;
					cars[carModel].DistanceTraveled += distance;
				}
			}

			inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}

		foreach (var car in cars)
		{
			Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.DistanceTraveled}");
		}

	}

	private static void AddCars(int numberOfCars, Dictionary<string, Car> cars)
	{
		for (int i = 0; i < numberOfCars; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var carModel = inputLine[0];
			var fuelAmount = double.Parse(inputLine[1]);
			var fuelConsumption = double.Parse(inputLine[2]);
			var car = new Car();
			if (!cars.ContainsKey(carModel))
			{
				cars.Add(carModel, new Car());
			}
			car.Model = carModel;
			car.FuelAmount = fuelAmount;
			car.DistanceTraveled = 0;
			car.FuelConsumptionFor1km = fuelConsumption;
			cars[carModel] = car;
		}
	}
}

