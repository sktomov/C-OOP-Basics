public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    public Animal(string animalType, string animalName, double animalWeight)
    {
        this.AnimalName = animalName;
        this.animalType = animalType;
        this.animalWeight = animalWeight;
    }

    protected int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }



    protected double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }


    protected string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }



    protected string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    public abstract void Eat(Food food);
    public abstract string MakeSound();
}

