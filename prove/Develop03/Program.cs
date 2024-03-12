using System;

class Program
{
    private static Scripture scripture = new Scripture("1 Nephi 3:15", "And my father dwelt in a tent.");

    static void Main(string[] args)
    {
        while (true) {
            Console.Clear();
            Display();
            if (CheckIfDone()) {
                Console.WriteLine("Congratulations, you completed it all");
                break;
            }
            if (!PromptUser()) {
                Console.WriteLine("Thanks For playing");
                break;
            }
        }
    }

    static bool CheckIfDone() {
        return scripture.IsAllBlank();
    }

    static bool PromptUser() {
        Console.WriteLine("Press enter to continue, type 'quit' to quit.");
        string response = Console.ReadLine();
        if (response == "") {
            scripture.EraseWords(3);
            return true;
        }
        return false;
    }
    
    static void Display() {
        Console.WriteLine(scripture.Display());
    }
}