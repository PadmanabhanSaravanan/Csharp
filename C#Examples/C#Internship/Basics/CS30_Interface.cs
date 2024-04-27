using System;

public interface IShape
{
    double GetArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle12 : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle12(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

public class CS30_Interface
{
     void Main(string[] args)
    {
        IShape shape1 = new Circle(5);
        IShape shape2 = new Rectangle12(10, 20);
        Console.WriteLine("Area of shape1: {0}", shape1.GetArea());
        Console.WriteLine("Area of shape2: {0}", shape2.GetArea());
    }
}
