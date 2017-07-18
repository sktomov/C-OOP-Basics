using System;

public class StartUp
{
    public static void Main()
    {
        var firstVehicleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var secondVehicleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var thirdVehicleInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Car car = new Car(double.Parse(firstVehicleInfo[1]), double.Parse(firstVehicleInfo[2]), double.Parse(firstVehicleInfo[3]));
        Truck truck = new Truck(double.Parse(secondVehicleInfo[1]), double.Parse(secondVehicleInfo[2]), double.Parse(secondVehicleInfo[3]));
        Bus bus = new Bus(double.Parse(thirdVehicleInfo[1]), double.Parse(thirdVehicleInfo[2]), double.Parse(thirdVehicleInfo[3]));



        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            try
            {
                var cmd = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = cmd[0];
                var vehicle = cmd[1];
                var distanceOrFuelInfo = double.Parse(cmd[2]);
                if (command.ToLower() == "drive")
                {
                    if (vehicle.ToLower() == "car")
                    {
                        Console.WriteLine(car.Drive(distanceOrFuelInfo, 0.9));

                    }
                    else if (vehicle.ToLower() == "truck")
                    {
                        Console.WriteLine(truck.Drive(distanceOrFuelInfo, 1.6));

                    }
                    else if (vehicle.ToLower() == "bus")
                    {
                        Console.WriteLine(bus.Drive(distanceOrFuelInfo, 1.4));

                    }
                }
                else if (command.ToLower() == "refuel")
                {
                    if (vehicle.ToLower() == "car")
                    {
                        car.RefillTank(distanceOrFuelInfo);
                    }
                    else if (vehicle.ToLower() == "truck")
                    {
                        truck.RefillTank(distanceOrFuelInfo);
                    }
                    else if (vehicle.ToLower() == "bus")
                    {
                        bus.RefillTank(distanceOrFuelInfo);
                    }
                }
                else
                {
                    Console.WriteLine(bus.Drive(distanceOrFuelInfo, 0));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}

