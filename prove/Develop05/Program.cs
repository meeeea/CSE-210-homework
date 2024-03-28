using System;

// the checklist goals show what the next step is.
// there is a level manager that keeps track of leveling up

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.MainLoop();
    }
}