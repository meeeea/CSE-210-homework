using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class GoalManager {
    private List<Goal> _goals = new List<Goal>();

    private int _totalScore = 0;

    public void Add(Goal goal) {
        _goals.Add(goal);
    }

    private void Display() {
        Console.WriteLine($"\nTotoal Score: {_totalScore}");
        for (int i = 0; i < _goals.Count; i ++) {
            Console.WriteLine($"{i + 1}: " + _goals[i].Display());
        }
    }

    public void MainLoop() {
        while (true) {
            MenuDisplay();
        }
    }

    private void MenuDisplay() {
        Console.WriteLine("\n1. Create New Goals");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. save Goals (TODO)");
        Console.WriteLine("4. Load Goals (TODO)");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select: ");

        int response = int.Parse(Console.ReadLine());

        Console.Clear();

        switch (response) {
            case 1:
                NewGoal();
                return;
            case 2:
                Display();
                return;

            case 5:
                RecordEvent();
                return;
            case 6:
                Environment.Exit(1);
                break;
        }
    }

    private void NewGoal() {
        Console.Clear();
        Console.WriteLine("\nSelect Goal Type");
        Console.WriteLine("1. Event (one time)");
        Console.WriteLine("2. Eternal (repeting indefinantly)");
        Console.WriteLine("3. Checklist (a set of steps)");
        Console.WriteLine("4. Cancel");
        Console.Write("Select: ");
        int response = int.Parse(Console.ReadLine());
        switch (response) {
            case 1:
                NewEvent();
                break;
            case 2:
                NewRepeter();
                break;
            case 3:
                NewChecklist();
                break;
        }
    }

    private void NewEvent() {
        Console.WriteLine("Please Name the Event");
        string name = Console.ReadLine();
        Console.WriteLine("Please Select the Number of Points it is Worth.");
        int value = int.Parse(Console.ReadLine());
        Add(new Event(value, name));
    }

    private void NewRepeter() {
        Console.WriteLine("Please Name the Event");
        string name = Console.ReadLine();
        Console.WriteLine("Please Select the Number of Points it is Worth.");
        int value = int.Parse(Console.ReadLine());
        Add(new Repeter(value, name));
    }

    private void NewChecklist() {
        Console.WriteLine("What will the name of the checklist be? ");
        string name = Console.ReadLine();
        
        List<string> steps = new List<string>();
        while (true) {
            Console.WriteLine("Input step (don't type anything to end)");
            string response = Console.ReadLine();
            if (response == "") {
                break;
            }
            steps.Add(response);
        }
        Console.WriteLine("How many Points will each step be worth?");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("What will be the completion multiplier? ");
        int mult = int.Parse(Console.ReadLine());

        Add(new Checklist(value, name, steps.ToArray(), mult));
    }

    private void RecordEvent() {
        Display();
        Console.WriteLine("Select Goal to complete");
        int response = int.Parse(Console.ReadLine()) - 1;
        if (!this[response].IsComplete) {
            _totalScore += this[response].CompleteScore();
        }
    }

    public Goal this[int x]{
        get => _goals[x];
    }
}