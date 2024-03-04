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

    public string[] Display() {
        return new string[3] {$"{this._date.Display()}", $": {this._prompt}",
                                 $"\t{this._text}"};
    }

    public string Read() {
        return $"{this._date.Read()}|{this._prompt}|{this._text}";
    }

    public string GetDateDisplayOrder() {
        return this._date.GetDateDisplayOrder();
    }

    public void SetDateDisplayOrder(string order) {
        this._date.SetDateDisplayOrder(order);
    }
}