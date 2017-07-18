
using System;

public class Kitten : Cat
{
    
    public Kitten(string name, int age, string gender):
        base(name, age, gender)
    {
        base.Gender = "Female";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Miau");
    }
}

