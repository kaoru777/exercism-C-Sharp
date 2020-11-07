using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> RobotNamesList = new HashSet<string>();
    private readonly Random random = new Random();
    public Robot() => GenerateRobotName();
    public string Name { get; set; } = "";

    public void Reset() => GenerateRobotName();

    public string generateRandomValues()
    {
        var returnBotName = "";

        returnBotName += (char)('A' + random.Next(0, 26));
        returnBotName += (char)('A' + random.Next(0, 26));

        returnBotName += random.Next(0, 9);
        returnBotName += random.Next(0, 9);
        returnBotName += random.Next(0, 9);

        return returnBotName;
    }

    public void GenerateRobotName()
    {
        string botName = generateRandomValues();

        if (RobotNamesList.Contains(botName))
        {
            GenerateRobotName();
        }
        else
        {
            Name = botName;
            RobotNamesList.Add(botName);
        }
    }
}