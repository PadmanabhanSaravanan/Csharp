using System;
using System.Threading;

class CS81_ResolveADeadlock
{
    private static readonly object lock1 = new object();
    private static readonly object lock2 = new object();

     void Main()
    {
        Thread threadA = new Thread(DoWorkA);
        Thread threadB = new Thread(DoWorkB);

        threadA.Start();
        threadB.Start();

        // Wait for both threads to complete
        threadA.Join();
        threadB.Join();

        Console.WriteLine("Program completed.");
    }

    static void DoWorkA()
    {
        lock (lock1)
        {
            Console.WriteLine("Thread A acquired lock1.");

            // Introducing a delay to increase the likelihood of deadlock
            Thread.Sleep(100);

            lock (lock2)
            {
                Console.WriteLine("Thread A acquired lock2.");
                // Perform work with Resource 1 and Resource 2
            }
        }
    }

    static void DoWorkB()
    {
        lock (lock1)
        {
            Console.WriteLine("Thread B acquired lock1.");

            // Introducing a delay to increase the likelihood of deadlock
            Thread.Sleep(100);

            lock (lock2)
            {
                Console.WriteLine("Thread B acquired lock2.");
                // Perform work with Resource 1 and Resource 2
            }
        }
    }
}
