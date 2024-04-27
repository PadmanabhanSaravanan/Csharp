using System;
using System.Threading;

class CS76_RetrievingdatafromThread
{
     void Main()
    {
        // Start a new thread and pass a callback delegate
        Thread thread = new Thread(WorkerMethod);
        thread.Start(ResultCallback);

        // Main thread continues execution
        Console.WriteLine("Main thread");

        // Wait for the worker thread to complete
        thread.Join();
    }

    static void WorkerMethod(object callback)
    {
        // Simulate some time-consuming operation
        Thread.Sleep(2000);

        // Generate a result
        int result = 42;

        // Invoke the callback method and pass the result
        var callbackDelegate = (Action<int>)callback;
        callbackDelegate(result);
    }

    static void ResultCallback(int result)
    {
        // Handle the result received from the worker thread
        Console.WriteLine("Result received: " + result);
    }
}
