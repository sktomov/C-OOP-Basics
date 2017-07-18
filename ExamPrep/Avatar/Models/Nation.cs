using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation()
    {
        this.monuments = new List<Monument>();
        this.benders = new List<Bender>();
    }

    public void AddBender(Bender bender) => this.benders.Add(bender);
    public void AddMonument(Monument monument) => this.monuments.Add(monument);

    public double CalculatePoints()
    {
        var power = this.benders.Sum(b => b.GetTotalPower());
        var bonus = this.monuments.Sum(m => m.GetMonumentBonus());

        return power += power / 100 * bonus;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        if (this.benders.Count > 0)
        {
            sb.AppendLine("Benders:");
            sb.AppendLine(string.Join(Environment.NewLine, benders));
        }
        else
        {
            sb.AppendLine("Benders: None");
        }
        if (this.monuments.Count > 0)
        {
            sb.AppendLine("Monuments:");
            sb.AppendLine(string.Join(Environment.NewLine, monuments));
        }
        else
        {
            sb.AppendLine("Monuments: None");
        }
        return sb.ToString().Trim();
    }

    public void KillYourSelf()
    {
        this.benders.Clear();
        this.monuments.Clear();
    }
}

