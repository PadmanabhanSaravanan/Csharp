using System;

public class Rectangle
{
    // Fields (data)
    private int length;
    private int width;

    // Constructor
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    // Properties
    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    // Method
    public int Area()
    {
        return length * width;
    }
}

public class CS18_Class
{
     void Main()
    {
        Rectangle rect = new Rectangle(5, 10);
        rect.Length = 7;
        rect.Width = 14;

        int area = rect.Area();
        Console.WriteLine("Area of the rectangle: " + area);
    }
}
