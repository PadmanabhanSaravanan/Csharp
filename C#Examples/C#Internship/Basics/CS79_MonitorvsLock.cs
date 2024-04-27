using System;
using System.Threading;

public class CS79_MonitorvsLock
{
    private static object _lock = new object();
    private static int Total = 0;

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 10; i++)
        {
            bool lockTaken = false;
            // Acquires the exclusive lock
            Monitor.Enter(_lock, ref lockTaken);
            try
            {
                Total++;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Total = {Total}");
            }
            finally
            {
                // Releases the exclusive lock
                if (lockTaken)
                    Monitor.Exit(_lock);
            }
        }
    }

    void Main(string[] args)
    {
        // Create and start two threads
        Thread thread1 = new Thread(AddOneMillion);
        Thread thread2 = new Thread(AddOneMillion);

        thread1.Start();
        thread2.Start();

        // Wait for both threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine($"Final Total: {Total}");
    }
}
