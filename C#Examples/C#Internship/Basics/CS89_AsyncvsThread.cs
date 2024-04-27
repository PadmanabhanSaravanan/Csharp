using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CS89_AsyncvsThread
{
    void Main(string[] args)
    {
        SomeMethod();
        Console.WriteLine("Main method code");
        Console.Read();
    }
    static async void SomeMethod()
    {
        await Task.Delay(5000);
        Console.WriteLine("Async code finishes");
    }
}
