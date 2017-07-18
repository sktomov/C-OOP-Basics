
using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var firstLine = Console.ReadLine().Trim();
        var animals = new List<Animal>();
        while (firstLine != "Beast!")
        {
            try
            {
                var secondLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = secondLine[0];
                int age = int.Parse(secondLine[1]);
                var gender = secondLine[2];

                var animal = AnimalSorter.CreateAnimal(firstLine, name, age, gender);
                animals.Add(animal);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            firstLine = Console.ReadLine().Trim();
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType());
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            animal.ProduceSound();
        }
    }
}

