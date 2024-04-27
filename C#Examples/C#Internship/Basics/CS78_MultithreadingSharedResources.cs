using System;
using System.Threading;

class CS78_MultithreadingSharedResources
{
    static int Total = 0;
    void Main()
    {
        Thread thread1 = new Thread(CS78_MultithreadingSharedResources.AddOneMillion);
        Thread thread2 = new Thread(CS78_MultithreadingSharedResources.AddOneMillion);
        Thread thread3 = new Thread(CS78_MultithreadingSharedResources.AddOneMillion);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Total = " + Total);
    }

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
            Total++;
        }
    }
}