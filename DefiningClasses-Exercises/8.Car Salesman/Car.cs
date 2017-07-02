
using System.Collections.Generic;

public class Car
{
	public Car(Engine engine, Tire tire1, Tire tire2, Tire tire3, Tire tire4)
	{
		this.Engine = engine;
		this.Tires = new List<Tire>()
		{
			tire1,
			tire2,
			tire3,
			tire4
		};
	}
	public string Model { get; set; }

	public int Weight { get; set; }

	public string CargoType { get; set; }

	public Engine Engine { get; set; }

	public List<Tire> Tires { get; set; }
}

