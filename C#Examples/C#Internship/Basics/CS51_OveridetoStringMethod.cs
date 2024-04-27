using System;

class CS51_OveridetoStringMethod
{
    // Example usage:
    void Main(string[] args)
    {
        MyClass111 myObject = new MyClass111(); // Corrected class name
        myObject.Name = "John";
        myObject.Age = 30;

        // Call the overridden ToString() method
        Console.WriteLine(myObject.ToString());
    }
}

public class MyClass111
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
