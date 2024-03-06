class Date {
    string _displayOrder;
    int _month = 0;
    int _day = 0;
    int _year = 0;

    public Date(string display_order = "dmy", int day = 0, int month = 0, int year = 0) {
        this._displayOrder = display_order;
        this._day = day;
        this._month = month;
        this._year = year;
    }

    public string Display() {
        if (this._displayOrder == "mdy") {
            return $"{this._month}-{this._day}-{this._year}";
        }
        else if (this._displayOrder == "dmy") {
            return $"{this._day}-{this._month}-{this._year}";
        }
        else if (this._displayOrder == "ydm") {
            return $"{this._year}-{this._day}-{this._month}";
        }
        else if (this._displayOrder == "myd") {
            return $"{this._month}-{this._year}-{this._day}";
        }
        else if (this._displayOrder == "dym") {
            return $"{this._day}-{this._year}-{this._month}";
        }
        else {            
            return $"{this._year}-{this._month}-{this._day}";
        }
    }

    public string Read() {
        return $"{this._day}|{this._month}|{this._year}";
    }

    public string GetDateDisplayOrder() {
        return this._displayOrder;
    }

    public void SetDateDisplayOrder(string order) {
        this._displayOrder = order;
    }
}