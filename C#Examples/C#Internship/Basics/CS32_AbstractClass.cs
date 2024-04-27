using System;

abstract class Shape1
{
    public abstract double Area { get; }
    public abstract double Perimeter { get; }
}

class Rectangle13 : Shape1
{
    private double length;
    private double width;

    public Rectangle13(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area
    {
        get { return length * width; }
    }

    public override double Perimeter
    {
        get { return 2 * (length + width); }
    }
}

class CS32_AbstractClass
{
     void Main(string[] args)
    {
        Rectangle13 rectangle13 = new Rectangle13(10, 20);
        Console.WriteLine("Rectangle Area: {0}", rectangle13.Area);
        Console.WriteLine("Rectangle Perimeter: {0}", rectangle13.Perimeter);
    }
}
