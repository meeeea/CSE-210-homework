using System;

// for go above and beyond, I did fun colors when printing your journal.

class Program
{
    public static Journal journal = new Journal();

    public static string displayOrderDefault;
    
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
            else if (response == "load") {
                OpenJournal(); 
            }
            else if (response == "settings") {
                settings();
            }
            else {
                Console.WriteLine("Sorry, that isn't a valid command. Please try 'help'\n");
            }
        }
    }

    static void settings() {
        while (true) {
            Console.WriteLine("Command: ");

            string response = Console.ReadLine().ToLower();

            if (response == "date") {
                SetDateDisplayOrder();
                // TODO this
            }
            else if (response == "return") {
                return;
            }
            else {
                Console.WriteLine("Sorry, that isn't a valid command. Please try 'help'\n");
            }
        }
    }

    static void SetDateDisplayOrder() {
        while (true) {
            Console.WriteLine("Display Order (ie: dmy, mdy, ydm): ");
        
            string order = Console.ReadLine();
            
            List<string> valid_orders = new List<string>() {"dmy", "mdy", "ydm", 
                                                            "ymd", "dym", "myd"};
            if (valid_orders.Contains(order)) {
                journal.SetDateDisplayOrder(order);
                return;
            }
        }
    }

    static void DisplaySettingsHelpMenu() {
        Console.WriteLine("Commands:");
        Console.WriteLine("'date' : set the date display order (ie: d-m-y).");
        Console.WriteLine("'return' : return to previous menue.");

        Console.WriteLine();
    }

    static void DislpayHelpMenu() {
        Console.WriteLine("Commands:");
        Console.WriteLine("'help' : Show this list.");
        Console.WriteLine("'quit' : Exit the program.");
        Console.WriteLine("'journal' : Display journal.");
        Console.WriteLine("'save' : Saves journal");
        Console.WriteLine("'add' : Adds an entery to your journal.");
        Console.WriteLine("'load' : Loads a journal from selected location.");
        Console.WriteLine("'settings' : modify settings");

        Console.WriteLine();
    }

    static void quit() {
        Console.WriteLine("Type 'yes' To Confirm.");
        string response = Console.ReadLine();
        
        if (response != "yes") {
            return;
        }
        System.Environment.Exit(0);
    }

    static void OpenJournal() {
        Console.WriteLine("File Name: ");

        string fileName = Console.ReadLine(); 

        journal = ReaderWriter.ReadJournal(fileName);

        displayOrderDefault = journal.GetDateDisplayOrder();
    }

    static void DisplayJournal() {
        journal.Display();
        Console.WriteLine();
    }

    static void AddEntery() {
        List<string> prompts = ReaderWriter.ReadPrompts();

        string prompt = prompts[new Random().Next(prompts.Count)];
        
        Console.WriteLine(prompt);
        
        string response = Console.ReadLine();

        DateTime stamp = DateTime.Now;
        
        Entery newEntery = new Entery(new Date(displayOrderDefault, stamp.Day, stamp.Month,
                                                stamp.Year), prompt, response);

        journal.Add(newEntery);

    }

    static void SaveJournal() {

        Console.WriteLine("File Name: ");

        string fileName = Console.ReadLine(); 

        ReaderWriter.WriteJournal(journal, fileName);
    }
}