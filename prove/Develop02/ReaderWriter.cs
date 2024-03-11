class ReaderWriter {

    public static Journal ReadJournal(string FileName) {
        try {
            Journal returnable = new Journal();
            using (TextReader reader = File.OpenText($".\\prove\\Develop02\\text_files\\{FileName}"))  {  
                string display_order = reader.ReadLine();
                while (true) {
                    string nextLine = reader.ReadLine();
                    if (nextLine == null) {
                        break;
                    }
                    string[] line = nextLine.Split('|');
                    returnable.Add(new Entery(new Date(display_order, Int32.Parse(line[0]),
                        Int32.Parse(line[1]), Int32.Parse(line[2])), line[3], line[4]));
                }
            } 
            return returnable;
        }
        catch (FileNotFoundException){
            return new Journal();
        }
    }

    public static List<string> ReadPrompts() {
        try {
            List<string> returnable = new List<string>();
            using (TextReader reader = File.OpenText($".\\prove\\Develop02\\text_files\\prompts.txt"))  {  
                    while (true) {
                        string line = reader.ReadLine();
                        if (line == null) {
                            break;
                        }
                        returnable.Add(line);
                    }
                } 
            return returnable;
        }
        catch (FileNotFoundException) {
            Console.WriteLine("sorry, couldn't find file 'prompts.txt' in folder text_files");
            System.Environment.Exit(3);
        }
        return null;        
    }

    public static void WriteJournal(Journal journal, string FileName) {
        using (StreamWriter writer = File.CreateText($".\\prove\\Develop02\\text_files\\{FileName}"))
            {
                writer.WriteLine(journal.GetDateDisplayOrder());
                foreach (string line in journal.Read()) {
                    writer.WriteLine(line);
                }
            }
    }
}