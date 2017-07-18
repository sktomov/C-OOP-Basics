
using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private string facultyNumber;
    public Student(string firstName, string lastName, string facultyNumber):
        base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get => this.facultyNumber;
        private set
        {
            if (value.Length > 5 && value.Length < 10 && value.All(char.IsLetterOrDigit))
            {
                this.facultyNumber = value;
            }
            else
            {
                throw  new ArgumentException("Invalid faculty number!");
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("First Name: ").AppendLine(base.FirstName)
            .Append("Last Name: ").AppendLine(base.LastName)
            .Append("Faculty number: ").Append(this.FacultyNumber)
            .AppendLine();
        return sb.ToString();
    }
}

