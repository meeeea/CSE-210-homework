class Journal {

    List<Entery> _enteries = new List<Entery>();
    public void Add(Entery entery) {
        this._enteries.Add(entery);
    }

    public void Display() {
        if (this._enteries.Count > 0) {
            foreach (Entery entery in this._enteries) {
                string[] display = entery.Display();
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(display[0]);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(display[1]);

                ConsoleColor[] colors = new ConsoleColor[13] {ConsoleColor.Gray,ConsoleColor.Blue,
                            ConsoleColor.Green,ConsoleColor.Cyan,ConsoleColor.Red,
                            ConsoleColor.Magenta,ConsoleColor.White,ConsoleColor.Black,
                            ConsoleColor.Gray,ConsoleColor.Blue,
                            ConsoleColor.Cyan,ConsoleColor.Red,ConsoleColor.Magenta};
                
                Console.ForegroundColor = colors[new Random().Next(13)];
                Console.WriteLine(display[2]);

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else {
            Console.WriteLine("There are no items in this journal, try adding some.");
        }
    }

    public string GetDateDisplayOrder() {
        if (this._enteries.Count > 0) {
            return this._enteries[0].GetDateDisplayOrder(); 
        }
        return "mdy";
    }   

    public string[] Read() {
        List<string> returnable = new List<string>();
        foreach (Entery entery in this._enteries) {
            returnable.Add(entery.Read());
        }
        return returnable.ToArray();
    }

    public void SetDateDisplayOrder(string order) {
        foreach (Entery entery in this._enteries) {
            entery.SetDateDisplayOrder(order);
        }
    }
}