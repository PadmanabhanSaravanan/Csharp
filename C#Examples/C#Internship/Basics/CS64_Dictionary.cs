using System;
using System.Collections.Generic;

public class CS64_Dictionary
{
     void Main()
    {
        Dictionary<string, int> studentScores = new Dictionary<string, int>();

        // Adding key-value pairs
        studentScores["Alice"] = 85;
        studentScores["Bob"] = 92;
        studentScores["Charlie"] = 78;

        // Accessing values by key
        int aliceScore = studentScores["Alice"]; // Returns 85

        // Checking if a key exists
        bool hasBob = studentScores.ContainsKey("Bob"); // Returns true

        // Updating values
        studentScores["Charlie"] = 82;

        // Removing a key-value pair
        studentScores.Remove("Alice");

        // Iterating over key-value pairs
        foreach (KeyValuePair<string, int> pair in studentScores)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
