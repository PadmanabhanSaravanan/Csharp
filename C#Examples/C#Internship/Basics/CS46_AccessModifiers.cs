using System;

public class MyClass2
{
    public int publicField;
    protected bool protectedField;
    internal double internalField;
    protected internal float protectedInternalField;
    private protected decimal privateProtectedField;
}

class CS46_AccessModifiers
{
    void Main()
    {
        MyClass2 myObject = new MyClass2();

        myObject.publicField = 10;
        myObject.internalField = 3.14;
        myObject.protectedInternalField = 1.234f;

        Console.WriteLine(myObject.publicField);
        Console.WriteLine(myObject.internalField);
        Console.WriteLine(myObject.protectedInternalField);
    }
}
