class Activity {
    protected string _name;
    public string name {get => _name;}

    protected string _description;
    public string description {get => _description;}

    protected int _activityDurration;
    public int activityDurration {get => _activityDurration;}

    public Activity(string name, string activityDescription) {
        _name = name;
        _description = activityDescription;
    }

    public void SetActivityDurration() {
        while (true) {
            try {
                Console.Write("How long, in seconds, would you like your session? ");
                _activityDurration = int.Parse(Console.ReadLine());

            }
            catch {
                continue;
            }
            break;
        }
    }

    protected void StartDisplay() {
        Console.WriteLine($"{name}, {description}");
        Thread.Sleep(1000);
        Console.WriteLine("Get Ready...");
        Wait(3, false);
    }

    protected static void EndDisplay() {
        Console.WriteLine("Good Job!");
        Wait(5, false);
    }

    protected static void Wait(int seconds, bool isNum = true) {
        string[] spinner = new string[4] {"|", "/", "-", "\\"};

        for (int i = 0; i < seconds; i++)
        {
            if (isNum) {
                Console.Write($"\b{seconds - i}");
            }
            else {
                Console.Write($"\b{spinner[i % 4]}");
            }
            Thread.Sleep(1000);
        }
        Console.Write("\b");
    }

    public virtual void RunActivity() {

    }
}