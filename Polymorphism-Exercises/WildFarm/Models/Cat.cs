
public class Cat : Felime
{
    private string breed;

    public string Breeed
    {
        get { return breed; }
        set { breed = value; }
    }

    public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion)
    {
        this.Breeed = breed;
    }

    public override void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    public override string MakeSound()
    {
        return "Meowwww";
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

