class Rectangle : Shape {
    private float _length;
    private float _height;

    public Rectangle(string color, float length, float height) : base(color) {
        _length = length;
        _height = height;
    }

    public override float GetArea()
    {
        return _length * _height;
    }
}