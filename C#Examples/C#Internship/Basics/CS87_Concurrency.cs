using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class CS87_Concurrency
{
     void Main(string[] args)
    {
        NewMethod();

        NewMethod1();

        Console.WriteLine("Start Data input, Enter you Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }

    private static async void NewMethod1()
    {
        await Task.Delay(10000);
        Console.WriteLine("Downloaded file1");
    }

    private static async void NewMethod()
    {
        await Task.Delay(10000);
        Console.WriteLine("Downloaded file2");
    }
}

