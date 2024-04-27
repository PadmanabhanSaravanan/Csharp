using System;

class Shape
{
    protected int width;
    protected int height;

    public void SetWidth(int w)
    {
        width = w;
    }

    public void SetHeight(int h)
    {
        height = h;
    }
}

class Rectangle1 : Shape
{
    public int GetArea()
    {
        return (width * height);
    }
}

class CS22_Inheritance
{
     void Main()
    {
        Rectangle1 rect = new Rectangle1();
        rect.SetWidth(5);
        rect.SetHeight(10);
        int area = rect.GetArea();
        Console.WriteLine("Area of rectangle = {0}", area);
    }
}
