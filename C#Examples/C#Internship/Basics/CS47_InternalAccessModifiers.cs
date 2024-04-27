using System;

public class BaseClass3
{
    protected internal int ProtectedInternalField;
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("BaseClass: ProtectedInternalMethod called.");
    }
}

public class DerivedClass3 : BaseClass3
{
    public void AccessProtectedInternalMembers()
    {
        ProtectedInternalField = 10; // Accessible in derived class
        ProtectedInternalMethod();  // Accessible in derived class
    }
}

class CS47_InternalAccessModifiers
{
    void Main(string[] args)
    {
        DerivedClass3 derivedObj = new DerivedClass3();
        derivedObj.AccessProtectedInternalMembers();

        Console.WriteLine("DerivedClass: ProtectedInternalField value: " + derivedObj.ProtectedInternalField);
        derivedObj.ProtectedInternalMethod();
    }
}
