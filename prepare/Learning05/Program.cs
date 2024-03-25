using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle("blue", 2F, 3F));
        shapes.Add(new Square("green", 3.5F));
        shapes.Add(new Circle("orange", 12F));

        foreach (Shape shape in shapes) {
            Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");            
        }
    }
}