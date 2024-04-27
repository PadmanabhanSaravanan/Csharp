using System;

class BaseClass1
{
    public void Method1()
    {
        Console.WriteLine("BaseClass.Method1");
    }
}

class DerivedClass1 : BaseClass1
{
    public new void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");

        // Call the Method1 implementation from the base class
        base.Method1();
    }
}

class CS23_MethodHiding
{
     void Main()
    {
        DerivedClass1 obj = new DerivedClass1();
        obj.Method1();
    }
}
