using System;
using System.Threading;
using System.Threading.Tasks;

class CS85_Tasks
{
    void Main(string[] args)
    {
        // Start a new task
        Task task = Task.Run(() =>
        {
            // Simulate some work
            Thread.Sleep(2000);
            Console.WriteLine("Task completed.");
        });

        Console.WriteLine("Main thread continues...");

        // Wait for the task to complete
        task.Wait();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
