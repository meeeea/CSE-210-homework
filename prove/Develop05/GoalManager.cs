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
        Console.WriteLine("3. save Goals");
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
            case 3:
                SaveGoalSet();
                return;
            case 4:
                LoadGoalSet();
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

    private void SaveGoalSet() {
        Console.WriteLine("input name of file");
        string FileName = Console.ReadLine();
        using (StreamWriter writer = File.CreateText($"text_files\\{FileName}.gs")){
            writer.Write(_totalScore);
            foreach (Goal goal in _goals) {
                goal.Save(writer);
            }
        }
    }

    private void LoadGoalSet() {
        try {
            Console.WriteLine("input name of file");
            string FileName = Console.ReadLine();
            
            _goals = new List<Goal>();
            
            using (StreamReader reader = File.OpenText($"text_files\\{FileName}.gs")) {
                _totalScore = int.Parse(reader.ReadLine());
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null) {
                        break;
                    }
                    string[] lineParts = line.Split('|');
                    if (lineParts[0] == "Event") {
                        Add(new Event(int.Parse(lineParts[3]), lineParts[2], int.Parse(lineParts[2]) == 1));
                    }
                    else if (lineParts[0] == "Repeter") {
                        Add(new Repeter(int.Parse(lineParts[2]), lineParts[1]));
                    }
                    else {
                        string checklistName = lineParts[1];

                        Steps steps = new Steps();

                        int index = 2;
                        int value;
                        while (true) {
                            if (int.TryParse(lineParts[index], out value)) {
                                break;
                            }   
                            else {
                                steps.Add(lineParts[index], lineParts[index + 1] == "1");
                            }
                            index += 2;
                        }
                        Add(new Checklist(value, lineParts[1], steps, int.Parse(lineParts[^1])));
                    }
                }
            }
        }
        catch (FileNotFoundException) {
            Console.WriteLine("I'm sorry, I could not find that file, have you checked that your root folder is Develop05?");
            Environment.Exit(2);
        }
    }

    public Goal this[int x] {
        get => _goals[x];
    }
}