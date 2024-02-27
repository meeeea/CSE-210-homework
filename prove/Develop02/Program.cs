using System;

class Program
{
    public static Journal journal = new Journal();
    static void Main(string[] args)
    {
        OpenJournal();
        DisplayJournal();

        MainLoop();
    }

    static void MainLoop() {
        while (true) {
            Console.WriteLine("Command: ");

            string response = Console.ReadLine().ToLower();

            if (response == "help") {
                DislpayHelpMenu();
            }
            else if (response == "quit") {
                quit();
            }
            else if (response == "save") {
                SaveJournal();
            }
            else if (response == "journal") {
                DisplayJournal();
            }
            else if (response == "add") {
                AddEntery();
            }
            else {
                Console.WriteLine("Sorry, that isn't a valid command. Please try 'help'\n");
            }
        }
    }

    static void DislpayHelpMenu() {
        Console.WriteLine("Commands:");
        Console.WriteLine("'help' : Show this list.");
        Console.WriteLine("'quit' : Exit the program.");
        Console.WriteLine("'journal' : Display journal.");
        Console.WriteLine("'save' : Saves journal");
        Console.WriteLine("'add' : dds an entery to your journal.\n");
    }

    static void quit() {
        Console.WriteLine("Would you like to ensure your journal was saved?");
        string response = Console.ReadLine();
        
        if (response == "yes") {
            return;
        }
        System.Environment.Exit(0);
    }

    static void OpenJournal() {
        journal = ReaderWriter.ReadJournal();
    }

    static void DisplayJournal() {
        journal.Display();
        Console.WriteLine();
    }

    static void AddEntery() {
        List<string> propmts = ReaderWriter.ReadPrompts();
        
        Console.WriteLine(propmts[new Random().Next(propmts.Count)]);
        
        string response = Console.ReadLine();

        DateTime stamp = DateTime.Now;
        
        Entery new_entery = new Entery(new Date(stamp.Day, stamp.Month, stamp.Year), response);

        journal.Add(new_entery);

    }

    static void SaveJournal() {
        ReaderWriter.WriteJournal(journal);
    }
}