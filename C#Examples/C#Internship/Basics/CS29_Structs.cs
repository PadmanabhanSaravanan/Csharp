using System;

public struct Rectangle11
{
    public int Width;
    public int Height;

    public Rectangle11(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }
}

public class CS29_Structs
{
     void Main(string[] args)
    {
        Rectangle11 rect = new Rectangle11(10, 20);
        Console.WriteLine("Width: {0}, Height: {1}, Area: {2}", rect.Width, rect.Height, rect.Area());
    }
}
