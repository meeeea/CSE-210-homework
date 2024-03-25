abstract class Shape {
    private string _color;

    public Shape(string color) {
        _color = color;
    }

    public string GetColor() => _color;

    public abstract float GetArea();
}