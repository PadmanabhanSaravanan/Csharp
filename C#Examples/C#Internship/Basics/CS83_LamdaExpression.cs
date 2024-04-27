using System;

class CS83_LamdaExpression
{
    delegate void PrintDelegate(string message);

     void Main()
    {
        // Create an instance of the delegate using a lambda expression
        PrintDelegate printDelegate = message =>
        {
            Console.WriteLine("Lambda expression: " + message);
        };

        // Invoke the delegate
        printDelegate("Hello, world!");

        Console.ReadLine();
    }
}
