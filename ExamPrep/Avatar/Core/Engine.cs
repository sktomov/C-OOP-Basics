using System;
using System.Linq;

public class Engine
{
    private bool isWorking;
    private string input;
    private NationsBuilder builder;


    public Engine()
    {
        this.isWorking = true;
        this.builder = new NationsBuilder();
    }
    public void Run()
    {
        while (isWorking)
        {
            var cmdArgs = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = cmdArgs[0];
            cmdArgs.RemoveAt(0);

            switch (command)
            {
                case "Bender":
                    builder.AssignBender(cmdArgs);
                    break;
                case "Monument":
                    builder.AssignMonument(cmdArgs);
                    break;
                case "Status":
                    Console.WriteLine(builder.GetStatus(cmdArgs[0]));
                    break;
                case "War":
                    builder.IssueWar(cmdArgs[0]);
                    break;
                case "Quit":
                    Console.WriteLine(builder.GetWarsRecord());
                    isWorking = false;
                    break;
            }
        }
    }
}

