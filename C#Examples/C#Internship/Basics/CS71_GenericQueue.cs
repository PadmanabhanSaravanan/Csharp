using System;
using System.Collections.Generic;

class CS71_GenericQueue
{
     void Main()
    {
        // Create a queue of strings
        Queue<string> names = new Queue<string>();

        // Enqueue elements to the queue
        names.Enqueue("Alice");
        names.Enqueue("Bob");
        names.Enqueue("Charlie");

        // Get the count of elements in the queue
        int count = names.Count;
        Console.WriteLine($"Number of elements in the queue: {count}");

        // Peek at the next element without removing it
        string nextName = names.Peek();
        Console.WriteLine($"Next name in the queue: {nextName}");

        // Dequeue elements from the queue
        while (names.Count > 0)
        {
            string dequeuedName = names.Dequeue();
            Console.WriteLine($"Dequeued name: {dequeuedName}");
        }

        // Check if an element is in the queue
        bool containsBob = names.Contains("Bob");
        Console.WriteLine($"Does the queue contain 'Bob'? {containsBob}");

        // Clear the queue
        names.Clear();

        // Convert the queue to an array
        string[] namesArray = names.ToArray();

        // Enumerate the queue using foreach loop
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}