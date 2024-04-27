using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CS90_AsyncvsThread1
{
    void Main(string[] args)
    {
        Thread x = new Thread(SomeMethod);
        x.Start();
        Console.WriteLine("Main method code");
        Console.Read();
    }
    static void SomeMethod()
    {
        Task.Delay(5000);
        Console.WriteLine("Async code finishes");
    }
}
