using System;

class CS82_AnonymousMethods
{
    delegate void PrintDelegate(string message);

     void Main()
    {
        // Create an instance of the delegate using an anonymous method
        PrintDelegate printDelegate = delegate (string message)
        {
            Console.WriteLine("Anonymous method: " + message);
        };

        // Invoke the delegate
        printDelegate("Hello, world!");

        // Assign a new anonymous method to the delegate
        printDelegate = delegate (string message)
        {
            Console.WriteLine("New anonymous method: " + message);
        };

        // Invoke the delegate again with the new method
        printDelegate("Hola!");

        Console.ReadLine();
    }
}