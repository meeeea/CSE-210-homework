class ReflectionActivity : Activity {
    private static string theDescription = "";

    public ReflectionActivity() : base("Reflection Activity", theDescription) {
        RunActivity();
    }

    public override void RunActivity()
    {
        SetActivityDurration();

        StartDisplay();

        int timer = 0;
        while (timer < activityDurration) {
            Console.WriteLine(Prompt());
            Wait(3);
            Console.WriteLine(PromptFurther());
            Wait(5);
            timer += 8;
        }

        EndDisplay();
    }

    private static string Prompt() {
        string[] prompts = new string[4] {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        return prompts[new Random().Next(4)];
    }

    private static string PromptFurther() {
        string[] prompts = new string[9] {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        return prompts[new Random().Next(9)];
    }
}