using System;

public class MyCollection
{
    private string[] elements = new string[10];

    // Overloaded indexer with int parameter
    public string this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    }

    // Overloaded indexer with string parameter
    public string this[string key]
    {
        get
        {
            // Custom logic for retrieving value based on key
            foreach (string element in elements)
            {
                if (element == key)
                {
                    return element;
                }
            }
            return null; // Return null if the key is not found
        }
        set
        {
            // Custom logic for setting value based on key
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == key)
                {
                    elements[i] = value;
                    return;
                }
            }
            // If the key is not found, add a new element with the key and value
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == null)
                {
                    elements[i] = key;
                    return;
                }
            }
            // If there are no empty slots, throw an exception or handle it as desired
            throw new InvalidOperationException("No empty slots available in the collection.");
        }
    }
}

public class CS59_OverloadedIndexers
{
     void Main()
    {
        MyCollection collection = new MyCollection();

        // Using the int indexer
        collection[0] = "First Element";
        collection[1] = "Second Element";

        Console.WriteLine(collection[0]); // Output: First Element
        Console.WriteLine(collection[1]); // Output: Second Element

        // Using the string indexer
        collection["Key1"] = "Value1";
        collection["Key2"] = "Value2";

        Console.WriteLine(collection["Key1"]); // Output: Value1
    }
}