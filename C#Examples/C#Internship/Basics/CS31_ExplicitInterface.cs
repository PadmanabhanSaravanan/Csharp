using System;

interface IMyInterface
{
    void MyMethod();
}

class MyClass11 : IMyInterface
{
    void IMyInterface.MyMethod()
    {
        Console.WriteLine("Implementation of MyMethod in MyClass1");
    }
}

class CS31_ExplicitInterface
{
     void Main(string[] args)
    {
        MyClass11 myClass11 = new MyClass11();
        ((IMyInterface)myClass11).MyMethod(); // Call MyMethod through the interface
    }
}