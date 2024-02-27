class ReaderWriter {

    public static Journal ReadJournal() {
        Journal returnable = new Journal();
        using (TextReader reader = File.OpenText($".\\prove\\Develop02\\text_files\\journal.txt"))  {  
                while (true) {
                    string nextLine = reader.ReadLine();
                    if (nextLine == null) {
                        break;
                    }
                    string[] line = nextLine.Split('|');
                    returnable.Add(new Entery(new Date(Int32.Parse(line[0]), Int32.Parse(line[1]),
                        Int32.Parse(line[2])), line[3]));
                }
            } 
        return returnable;
    }

    public static List<string> ReadPrompts() {
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

    public static void WriteJournal(Journal journal) {
        using (StreamWriter writer = File.CreateText(".\\prove\\Develop02\\text_files\\journal.txt"))
            {
                foreach (string line in journal.Read()) {
                    writer.WriteLine(line);
                }
            }
    }
}