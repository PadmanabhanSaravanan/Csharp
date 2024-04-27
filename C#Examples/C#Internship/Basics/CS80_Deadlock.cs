using System;
using System.Threading;

class CS80_Deadlock
{
    static object resource1 = new object();
    static object resource2 = new object();

     void Main()
    {
        // Start two threads
        Thread thread1 = new Thread(DoWork1);
        Thread thread2 = new Thread(DoWork2);
        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Program completed.");
    }

    static void DoWork1()
    {
        lock (resource1)
        {
            Console.WriteLine("Thread 1 acquired resource 1.");

            // Introduce delay to increase the chance of deadlock
            Thread.Sleep(100);

            lock (resource2)
            {
                Console.WriteLine("Thread 1 acquired resource 2.");
                // Do some work with resource 1 and resource 2
            }
        }
    }

    static void DoWork2()
    {
        lock (resource2)
        {
            Console.WriteLine("Thread 2 acquired resource 2.");

            // Introduce delay to increase the chance of deadlock
            Thread.Sleep(100);

            lock (resource1)
            {
                Console.WriteLine("Thread 2 acquired resource 1.");
                // Do some work with resource 1 and resource 2
            }
        }
    }
}
