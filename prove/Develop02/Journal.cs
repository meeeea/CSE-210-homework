class Journal {

    List<Entery> _enteries = new List<Entery>();
    public void Add(Entery entery) {
        this._enteries.Add(entery);
    }

    public void Display(bool american = true) {
        foreach (Entery entery in this._enteries) {
            Console.WriteLine(entery.Display(american));
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