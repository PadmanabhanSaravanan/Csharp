using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class CS86_CouncurrencyvsParallelDemo
{
     void Main(string[] args)
    {

        Task.Delay(10000).Wait();
        Console.WriteLine("Downloaded file1");

        Task.Delay(10000).Wait();
        Console.WriteLine("Downloaded file2");

        Console.WriteLine("Start Data input, Enter you Name:");
        string str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }
}

