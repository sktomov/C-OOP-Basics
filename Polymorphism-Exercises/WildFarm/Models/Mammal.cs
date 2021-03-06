﻿public abstract class Mammal : Animal
{
    private string livingRegion;

    

    public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) : base(animalType, animalName, animalWeight)
    {
        this.LivingRegion = livingRegion;
    }
    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }
    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.livingRegion}, {this.FoodEaten}]";
    }
}

