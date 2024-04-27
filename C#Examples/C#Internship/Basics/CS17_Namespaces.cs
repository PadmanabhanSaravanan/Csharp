using System;

namespace MyNamespace
{
    class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("This is MyClass");
        }
    }
}

namespace AnotherNamespace
{
    class AnotherClass
    {
        public void AnotherMethod()
        {
            Console.WriteLine("This is AnotherClass");
        }
    }
}

class CS17_Namespaces
{
     void Main()
    {
        MyNamespace.MyClass obj1 = new MyNamespace.MyClass();
        AnotherNamespace.AnotherClass obj2 = new AnotherNamespace.AnotherClass();

        obj1.MyMethod();
        obj2.AnotherMethod();
    }
}
