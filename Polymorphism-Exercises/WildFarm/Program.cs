using System;

public class Program
{
   public static void Main()
   {
       var animalInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
       while (animalInfo[0] != "End")
       {
           Animal animal = CreateAnimal(animalInfo);
           var foodInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
           Food food = CreateFood(foodInfo);
           Console.WriteLine(animal.MakeSound());

           try
           {
                animal.Eat(food);
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }
           Console.WriteLine(animal);
            animalInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
   }

    private static Food CreateFood(string[] foodInfo)
    {
        var foodType = foodInfo[0];
        int quantity = int.Parse(foodInfo[1]);
        switch (foodType)
        {
            case "Meat":
                return new Meat(quantity);
            case "Vegetable":
                return new Vegetable(quantity);
            default:
                return null;

        }
    }

    private static Animal CreateAnimal(string[] animalInfo)
    {
        var animalType = animalInfo[0];
        var animalName = animalInfo[1];
        double animalWeight = double.Parse(animalInfo[2]);
        var livingRegion = animalInfo[3];
        switch (animalType)
        {
            case "Mouse":
                return new Mouse(animalType, animalName, animalWeight, livingRegion);
            case "Zebra":
                return new Zebra(animalType, animalName, animalWeight, livingRegion);
            case "Tiger":
                return new Tiger(animalType, animalName, animalWeight, livingRegion);
            case "Cat":
                var breed = animalInfo[4];
                return new Cat(animalType, animalName, animalWeight, livingRegion, breed);
            default:
                return null;
        }
    }
}

