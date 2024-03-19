using System.Diagnostics;

class ListingActivity : Activity {
    private static string theDescription = "This activity will help you reflect on the good " +
    "things in your life by having you list as many things as you can in a certain area.";

    public ListingActivity() : base("Listing Activity", theDescription) {
        RunActivity();
    }

    public override void RunActivity()
    {
        SetActivityDurration();

        StartDisplay();

        Console.WriteLine(Prompt());

        Stopwatch sw = Stopwatch.StartNew();

        int total = 0;

        while (true) {
            if (sw.ElapsedMilliseconds > activityDurration * 1000) {
                break;
            }
            if (Console.ReadLine() != "") {
                total += 1;
            }
        }
        Console.WriteLine($"Congratulations, you came up with {total} items!!!");
        Wait(5, false);

        EndDisplay();
    }

    private string Prompt() {
        string[] prompts = new string[5] {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        return prompts[new Random().Next(5)];
    }
}