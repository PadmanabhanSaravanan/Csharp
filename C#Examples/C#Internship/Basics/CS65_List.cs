using System;
using System.Collections.Generic;

class CS65_List
{
     void Main()
    {
        List<string> names = new List<string>();

        // Adding elements
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        // Accessing elements by index
        string firstElement = names[0];   // Returns "Alice"

        // Count of elements
        int count = names.Count;   // Returns 3

        // Removing elements
        names.Remove("Bob");
        bool isCharlieRemoved = names.Remove("Charlie");  // Returns true

        // Inserting elements at a specific index
        names.Insert(1, "Dave");

        // Iterating over the list
        foreach (string name in names)
        {
            Console.WriteLine("Name: " + name);
        }
    }
}
