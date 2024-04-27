using System;

class CS53_ConvertToStringvsToString
{
     void Main(string[] args)
    {
        // Example of using Convert.ToString()
        int number = 42;
        string numberString = Convert.ToString(number);

        Console.WriteLine($"Convert.ToString(): {numberString}");

        // Example of overriding the ToString() method in a custom class
        Person12 person = new Person12 { Name = "John", Age = 30 };
        string personString = person.ToString();

        Console.WriteLine($"Custom ToString(): {personString}");
    }
}

public class Person12
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
