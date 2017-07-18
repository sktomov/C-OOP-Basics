
using System;
using System.Linq;
using System.Reflection;

public class Program
{
	public static void Main()
	{
		//On the first three lines you will get the length, width and height. 
		var length = double.Parse(Console.ReadLine());
		var width = double.Parse(Console.ReadLine());
		var height = double.Parse(Console.ReadLine());
		Type boxType = typeof(Box);
		FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
		Console.WriteLine(fields.Count());
		try
		{
			var box = new Box(length, width, height);
			Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
			Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
			Console.WriteLine($"Volume - {box.Volume():f2}");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		
	}
}

