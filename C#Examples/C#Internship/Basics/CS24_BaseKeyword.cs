using System;

class BaseClass
{
    public void Method1()
    {
        Console.WriteLine("BaseClass.Method1");
    }
}

class DerivedClass : BaseClass
{
    public new void Method1()
    {
        Console.WriteLine("DerivedClass.Method1");
    }
}

class CS24_BaseKeyword
{
     void Main()
    {
        BaseClass obj1 = new BaseClass();
        obj1.Method1();  // Output: BaseClass.Method1

        DerivedClass obj2 = new DerivedClass();
        obj2.Method1();  // Output: DerivedClass.Method1

        BaseClass obj3 = new DerivedClass();
        obj3.Method1();  // Output: BaseClass.Method1
    }
}
