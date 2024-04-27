using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class CS67_Parallel
{
    void Main(string[] args)
    {
        Task.Factory.StartNew(NewMethod);
        Task.Factory.StartNew(NewMethod1);

        Console.WriteLine("Start Data input, Enter you Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }

    private static void NewMethod1()
    {
        Task.Delay(10000);
        Console.WriteLine("Downloaded file1");
    }

    private static void NewMethod()
    {
        Task.Delay(10000);
        Console.WriteLine("Downloaded file2");
    }
}

