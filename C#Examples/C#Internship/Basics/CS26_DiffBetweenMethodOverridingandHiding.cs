using System;

class BaseClass11
{
    public virtual void Method11()
    {
        Console.WriteLine("BaseClass.Method1");
    }

    public void Method22()
    {
        Console.WriteLine("BaseClass.Method2");
    }
}

class DerivedClass11 : BaseClass11
{
    public override void Method11()
    {
        Console.WriteLine("DerivedClass.Method1");
    }

    public new void Method22()
    {
        Console.WriteLine("DerivedClass.Method2");
    }
}

class CS26_DiffBetweenMethodOverridingandHiding
{
     void Main(string[] args)
    {
        BaseClass11 obj1 = new DerivedClass11();
        obj1.Method11(); // Output: DerivedClass.Method1
        obj1.Method22(); // Output: BaseClass.Method2

        DerivedClass11 obj2 = new DerivedClass11();
        obj2.Method11(); // Output: DerivedClass.Method1
        obj2.Method22(); // Output: DerivedClass.Method2
    }
}
