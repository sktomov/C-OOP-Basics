using System;
using System.IO;

public abstract class Vehicle
{
    private  double fuelQuantity { get; set; }
    private  double fuelConsumptionPerKm { get; set; }
    private double tankCapacity { get; set; }

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.fuelConsumptionPerKm = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
        this.tankCapacity = tankCapacity;
    }

    private double FuelQuantity
    {
        get => this.fuelQuantity;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.fuelQuantity = value;
        }
    }
    public virtual void RefillTank(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (fuel > this.tankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }
        this.fuelQuantity += fuel;
    }

    public string Drive(double distance, double airConditioningConsumption)
    {
        var needFuel = distance * (fuelConsumptionPerKm + airConditioningConsumption);
        if (needFuel > fuelQuantity)
        {
            return $"{this.GetType().Name} needs refueling";
        }
        this.fuelQuantity -= needFuel;
        return $"{this.GetType().Name} travelled {distance} km";
    }
    
    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}

