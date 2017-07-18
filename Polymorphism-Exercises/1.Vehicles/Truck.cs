public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override void RefillTank(double fuel)
    {
        fuel = fuel * 0.95;
        base.RefillTank(fuel);  
    }
}

