
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		Dictionary<string, Car> cars = new Dictionary<string, Car>();

		for (int i = 0; i < n; i++)
		{
			var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
			var carModel = inputLine[0];
			if (!cars.ContainsKey(carModel))
			{
				var engine = new Engine()
				{
					HorsePower = int.Parse(inputLine[2]),
					Speed = int.Parse(inputLine[1])
				};
				var tire1 = new Tire()
				{
					Age = int.Parse(inputLine[6]),
					Pressure = double.Parse(inputLine[5])
				};
				var tire2 = new Tire()
				{
					Age = int.Parse(inputLine[8]),
					Pressure = double.Parse(inputLine[7])
				};
				var tire3 = new Tire()
				{
					Age = int.Parse(inputLine[10]),
					Pressure = double.Parse(inputLine[9])
				};
				var tire4 = new Tire()
				{
					Age = int.Parse(inputLine[12]),
					Pressure = double.Parse(inputLine[11])
				};
				var car = new Car(engine, tire1, tire2, tire3, tire4);
				car.Model = inputLine[0];
				car.Weight = int.Parse(inputLine[3]);
				car.CargoType = inputLine[4];
				cars[carModel] = car;
			}
		}

		var cmd = Console.ReadLine().ToLower();
		if (cmd == "fragile")
		{
			if (cars.Any(x => x.Value.CargoType == "fragile"))
			{
				cars.Where(c => c.Value.CargoType == "fragile").Select(car => new
				{
					carName = car.Key,
					Pressure = car.Value.Tires
				}).Where(t => t.Pressure.Any(p => p.Pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.carName));

			}
		}
		else
		{
			if (cars.Any(x => x.Value.CargoType == "flamable"))
			{
				cars.Where(c => c.Value.CargoType == "flamable").Select(car => new
				{
					carName = car.Key,
					horsePower = car.Value.Engine.HorsePower
				}).Where(c => c.horsePower > 250).ToList().ForEach(c => Console.WriteLine(c.carName));

			}
		}
	}
}

