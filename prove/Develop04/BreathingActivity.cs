class BreathingActivity : Activity {
    private static string activityDescription = 
        "This activity will help you relax by walking your through breathing in and out slowly. " + 
        "Clear your mind and focus on your breathing";
    
    public BreathingActivity() : base("Breathing activity", activityDescription) {
        RunActivity();
    }

    public override void RunActivity() {
        SetActivityDurration();

        StartDisplay();

        int timer = 0;
        while (timer < activityDurration)
        {
            Console.WriteLine("Breath in...");
            Wait(5);
            Console.WriteLine("Breath out...");
            Wait(5);
            timer += 10;
            Console.Write("\b");
        }
        EndDisplay();
    }
}