﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> wars;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation()},
            {"Fire", new Nation()},
            {"Water", new Nation()},
            {"Earth", new Nation()}

        };
        this.wars = new List<string>();
    }
    public void AssignBender(List<string> benderArgs)
    {
        var type = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondaryParameter = double.Parse(benderArgs[3]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddBender(new AirBender(name, power, secondaryParameter));
                break;
            case "Water":
                this.nations[type].AddBender(new WaterBender(name, power, secondaryParameter));
                break;
            case "Earth":
                this.nations[type].AddBender(new EarthBender(name, power, secondaryParameter));
                break;
            case "Fire":
                this.nations[type].AddBender(new FireBender(name, power, secondaryParameter));
                break;
        }


    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        var affinity = int.Parse(monumentArgs[2]);

        switch (type)
        {
            case "Air":
                this.nations[type].AddMonument(new AirMonument(name, affinity));
                break;
            case "Water":
                this.nations[type].AddMonument(new WaterMonument(name, affinity));
                break;
            case "Earth":
                this.nations[type].AddMonument(new EarthMonument(name, affinity));
                break;
            case "Fire":
                this.nations[type].AddMonument(new FireMonument(name, affinity));
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        return $"{nationsType} Nation" + Environment.NewLine + this.nations[nationsType].ToString();
    }
    public void IssueWar(string nationsType)
    {
        this.wars.Add(nationsType);
        var winner = nations.Max(n => n.Value.CalculatePoints());
        foreach (var nation in nations)
        {
            if (nation.Value.CalculatePoints() != winner)
            {
                nation.Value.KillYourSelf();
            }
        }
    }
    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < wars.Count; i++)
        {
            sb.AppendLine($"War {i + 1} issued by {wars[i]}");
        }
        return sb.ToString().Trim();
    }

}

