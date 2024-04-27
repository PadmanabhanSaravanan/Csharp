using System;

public class MyClass1
{
    // Static field
    private static int count1;

    // Static constructor
    static MyClass1()
    {
        count1 = 0;
    }

    // Instance constructor
    public MyClass1()
    {
        count1++;
    }

    // Static method
    public static int GetCount()
    {
        return count1;
    }
}

public class CS21_StaticConstructor
{
     void Main()
    {
        // Create instances of MyClass
        MyClass1 obj1 = new MyClass1();
        MyClass1 obj2 = new MyClass1();
        MyClass1 obj3 = new MyClass1();

        // Access the static method to get the count
        int count = MyClass1.GetCount();

        Console.WriteLine("Count: " + count);
    }
}
