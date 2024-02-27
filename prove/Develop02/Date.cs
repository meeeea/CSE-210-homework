class Date {
    int _month = 0;
    int _day = 0;
    int _year = 0;

    public Date(int day = 0, int month = 0, int year = 0) {
        this._day = day;
        this._month = month;
        this._year = year;
    }

    public string Display(bool american = true) {
        if (american) {
            return $"{this._month}-{this._day}-{this._year}";
        }
        else {
            return $"{this._day}-{this._month}-{this._year}";
        }
    }

    public string Read() {
        return $"{this._day}|{this._month}|{this._year}";
    }
}