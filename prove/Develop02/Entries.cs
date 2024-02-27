class Entery {
    Date _date = new Date();
    string _text;

    public Entery(Date date = null, string text = "") {
        if (date != null) {
            this._date = date;
        }
        this._text = text;
    }

    public string Display(bool american = true) {
        return $"{this._date.Display(american)}: {this._text}";
    }

    public string Read() {
        return $"{this._date.Read()}|{this._text}";
    }
}