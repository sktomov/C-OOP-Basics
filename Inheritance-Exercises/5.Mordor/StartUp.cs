
using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var foodInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var foods = new List<Food>();
        foreach (var foodName in foodInfo)
        {
            var food = new Food(foodName);
            foods.Add(food);
        }
        var pointOfHappiness = foods.Sum(f => f.PointsOfHappiness);
        var mood = Mood.GetMood(pointOfHappiness);
        Console.WriteLine(pointOfHappiness);
        Console.WriteLine(mood);
    }
}

