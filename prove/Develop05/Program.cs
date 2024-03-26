using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Add(new Event(100, "go shoping"));
        goalManager.Add(new Repeter(100, "eat out"));
        string[] takeDogForWalkStrings = new string[3]{"find Leash", "find dog", "go on the walk"};
        goalManager.Add(new Checklist(100, "take dog for walk", takeDogForWalkStrings));
        goalManager.Add(new Event(100, "go eat sandwich"));
        goalManager.MainLoop();
    }
}