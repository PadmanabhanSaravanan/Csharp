using System;

class A
{
    public virtual void Foo() { Console.WriteLine("A.Foo()"); }
}

class B : A
{
    public override void Foo() { Console.WriteLine("B.Foo()"); }
}

class C : A
{
    public override void Foo() { Console.WriteLine("C.Foo()"); }
}

// class D : B, C
// {
// }

class CS34_DiamondProblem
{
    void Main()
    {
       // D d = new D();
       // d.Foo();
    }
}