using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CS93_SynchronizationContext
{
     void Main(string[] args)
    {
        Console.WriteLine("Code 1");
        Console.WriteLine("Code 2" + Thread.CurrentThread.ManagedThreadId);
        SomeMethod();
        Console.WriteLine("Code 7");
        Console.WriteLine("Code 8");
        Console.Read();
    }
    static async void SomeMethod()
    {
        Console.WriteLine("Code 1");
        Console.WriteLine("Code 2");
        await Task.Delay(10000);
        Console.WriteLine("Code 5");
        Console.WriteLine("Code 6" + +Thread.CurrentThread.ManagedThreadId);
        Console.Read();
    }
}
