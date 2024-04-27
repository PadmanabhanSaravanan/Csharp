using System;

public class MyClass
{
    // Instance field
    private int value;

    // Static field
    private static int count;

    // Constructor
    public MyClass(int value)
    {
        this.value = value;
        count++;
    }

    // Instance method
    public int GetValue()
    {
        return value;
    }

    // Static method
    public static int GetCount()
    {
        return count;
    }
}

public class CS19_StaticandInstanceClassMembers
{
     void Main()
    {
        // Create instances of MyClass
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(20);

        // Access instance members
        Console.WriteLine("Value of obj1: " + obj1.GetValue());
        Console.WriteLine("Value of obj2: " + obj2.GetValue());

        // Access static members
        Console.WriteLine("Count: " + MyClass.GetCount());
    }
}
