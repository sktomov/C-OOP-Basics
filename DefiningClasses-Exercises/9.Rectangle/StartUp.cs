
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
	public static void Main()
	{
		var inputLine = Console.ReadLine().Split(new[] {' '}).Select(int.Parse).ToArray();
		Dictionary<string, Rectangle> rects = new Dictionary<string, Rectangle>();

		for (int i = 0; i < inputLine[0]; i++)
		{
			var rectanglesToRead = Console.ReadLine().Split(new[] {' '});
			var id = rectanglesToRead[0];
			var width = double.Parse(rectanglesToRead[1]);
			var height = double.Parse(rectanglesToRead[2]);
			var topLeftX = double.Parse(rectanglesToRead[3]);
			var topLeftY = double.Parse(rectanglesToRead[4]);
			var rectangle = new Rectangle()
			{
				ID = id,
				Width = width,
				Height = height,
				TopLeftX = topLeftX,
				TopLeftY = topLeftY
			};
			rects[id] = rectangle;
		}

		for (int i = 0; i < inputLine[1]; i++)
		{
			var checkRectangles = Console.ReadLine().Split(new[] { ' ' });
			var firstRectangle = checkRectangles[0];
			var secondRectangle = checkRectangles[1];
			bool result = rects[firstRectangle].Intersect(rects[secondRectangle]);
			Console.WriteLine(result.ToString().ToLower());
		}
	}
}

