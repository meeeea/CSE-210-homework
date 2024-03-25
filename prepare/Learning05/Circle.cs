class Circle : Shape {
    private float _radius;
    private float Pi = 3.14192653589F;

    public Circle(string color, float radius) : base(color) {
        _radius = radius;
    }

    public override float GetArea()
    {
        return _radius * _radius * Pi;
    }
}