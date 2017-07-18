using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, decimal salary, double workingHours):
        base(firstName, lastName)
    {
        this.WeekSalary = salary;
        this.WorkHoursPerDay = workingHours;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        set
        {
            if (value > 1 && value < 12)
            {
                this.workHoursPerDay = value;
            }
            else
            {
                throw  new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
        }
    }

    private decimal SalaryPerHour()
    {

        return this.WeekSalary / 5 /(decimal) this.WorkHoursPerDay;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("First Name: ").AppendLine(base.FirstName)
            .Append("Last Name: ").AppendLine(base.LastName)
            .Append("Week Salary: ").AppendLine($"{this.WeekSalary:f2}")
            .Append("Hours per day: ").AppendLine($"{this.WorkHoursPerDay:f2}")
            .Append("Salary per hour: ").Append($"{this.SalaryPerHour():f2}")
            .AppendLine();
        return sb.ToString();
    }
}

