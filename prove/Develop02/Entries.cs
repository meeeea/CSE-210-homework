class Entery {
    Date _date = new Date();
    string _prompt;
    string _text;

    public Entery(Date date = null, string prompt = "", string text = "") {
        if (date != null) {
            this._date = date;
        }
        this._prompt = prompt;
        this._text = text;
    }

    public string[] Display(bool american = true) {
        return new string[3] {$"{this._date.Display(american)}", $": {this._prompt}",
                                 $"\t{this._text}"};
    }

    public string Read() {
        return $"{this._date.Read()}|{this._prompt}|{this._text}";
    }
}