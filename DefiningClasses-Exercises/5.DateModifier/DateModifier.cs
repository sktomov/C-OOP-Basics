
using System;

public class DateModifier
{
	private DateTime startDate;
	private DateTime endDate;

	public DateTime StartDate
	{
		get { return this.startDate; }
		set { this.startDate = value; }
	}
	public DateTime EndDate
	{
		get { return this.endDate; }
		set { this.endDate = value; }
	}

	public double GetDifference()
	{
		return Math.Abs((this.startDate - this.endDate).TotalDays);
	}
}

