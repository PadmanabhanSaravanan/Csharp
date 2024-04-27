using System;
using System.Collections.Generic;

class CS72_GenericStack
{
     void Main()
    {
        // Create a stack of integers
        Stack<int> numbers = new Stack<int>();

        // Push elements onto the stack
        numbers.Push(5);
        numbers.Push(10);
        numbers.Push(15);

        // Get the count of elements in the stack
        int count = numbers.Count;
        Console.WriteLine($"Number of elements in the stack: {count}");

        // Peek at the top element without removing it
        int topNumber = numbers.Peek();
        Console.WriteLine($"Top number in the stack: {topNumber}");

        // Pop elements from the stack
        while (numbers.Count > 0)
        {
            int poppedNumber = numbers.Pop();
            Console.WriteLine($"Popped number: {poppedNumber}");
        }

        // Check if an element is in the stack
        bool contains10 = numbers.Contains(10);
        Console.WriteLine($"Does the stack contain 10? {contains10}");

        // Clear the stack
        numbers.Clear();

        // Convert the stack to an array
        int[] numberArray = numbers.ToArray();

        // Enumerate the stack using foreach loop
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
