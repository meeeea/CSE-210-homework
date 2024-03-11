class Fraction {
    private int _top;
    public int top {
        get {return _top;}
        set {_top = value;}
    }
    private int _bottom;
    public int bottom {
        get {return _bottom;}
        set {
            if (value != 0) {
                _bottom = value;
            }
        }
    }

    public Fraction(int numerator = 1, int denominator = 1) {
        top = numerator;
        bottom = denominator;
    }

    public double GetDecimal() {
        return (double) top / bottom;
    }

    public string GetAsFraction() {
        return $"{top}/{bottom}";
    }
}