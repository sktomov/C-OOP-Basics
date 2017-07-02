
using System;


public class Program
{
	public static void Main()
	{
		DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
		DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
		DateModifier dateModifier = new DateModifier()
		{
			StartDate = firstDate,
			EndDate = secondDate
		};
		Console.WriteLine(dateModifier.GetDifference());
	}
}

