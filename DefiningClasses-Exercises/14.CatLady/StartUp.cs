
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
		var cats = new List<Cat>();
		while (inputLine[0] != "End")
		{
			var breed = inputLine[0];
			var catName = inputLine[1];
			var cat = new Cat(breed, catName);
			if (breed == "StreetExtraordinaire")
			{
				cat.Decibels = int.Parse(inputLine[2]);
			}
			else if (breed == "Siamese")
			{
				cat.EarSize = int.Parse(inputLine[2]);
			}
			else if (breed == "Cymric")
			{
				cat.FurLenght = double.Parse(inputLine[2]);
			}
			cats.Add(cat);
			inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		}

		var catToPrint = Console.ReadLine().Trim();
		var result = cats.FirstOrDefault(c => c.Name == catToPrint);
		if (result != null)
		{
			Console.WriteLine(result.ToString());
		}
	}
}

