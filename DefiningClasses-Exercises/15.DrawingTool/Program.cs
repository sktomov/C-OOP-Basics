
using System;


public class Program
{
	public static void Main()
	{
		var figure = Console.ReadLine();
		if (figure == "Square")
		{
			var a = int.Parse(Console.ReadLine());
			for (int i = 0; i < a; i++)
			{
				if (i == 0 || i == a - 1)
				{
					Console.WriteLine($"|{string.Join(" ", new string('-', a))}|");
				}
				else
				{
					Console.WriteLine($"|{new string(' ', a)}|");
				}
			}
		}
		else if (figure == "Rectangle")
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			for (int i = 0; i < b; i++)
			{
				if (i == 0 || i == b - 1)
				{
					Console.WriteLine($"|{string.Join(" ", new string('-', a))}|");
				}
				else
				{
					Console.WriteLine($"|{new string(' ', a)}|");
				}
			}
		}
	}
}

