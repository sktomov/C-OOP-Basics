using System;

public class Tiger : Felime
{
    public Tiger(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }
        this.FoodEaten += food.Quantity;
    }

    public override string MakeSound()
    {
        return "ROAAR!!!";
    }
}

