class Journal {

    List<Entery> _enteries = new List<Entery>();
    public void Add(Entery entery) {
        this._enteries.Add(entery);
    }

    public void Display(bool american = true) {
        foreach (Entery entery in this._enteries) {
            string[] display = entery.Display();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(display[0]);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(display[1]);

            ConsoleColor[] colors = new ConsoleColor[26] {ConsoleColor.Gray,ConsoleColor.Blue,
                        ConsoleColor.Green,ConsoleColor.Cyan,ConsoleColor.Red,
                        ConsoleColor.Magenta,ConsoleColor.White,ConsoleColor.Black,
                        ConsoleColor.Gray,ConsoleColor.Blue,
                        ConsoleColor.Cyan,ConsoleColor.Red,ConsoleColor.Magenta};
            
            Console.ForegroundColor = colors[new Random().Next(26)];
            Console.WriteLine(display[2]);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public string[] Read() {
        List<string> returnable = new List<string>();
        foreach (Entery entery in this._enteries) {
            returnable.Add(entery.Read());
        }
        return returnable.ToArray();
    }
}