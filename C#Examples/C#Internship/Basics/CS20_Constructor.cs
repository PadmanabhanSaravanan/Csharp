using System;

public class People
{
    // Fields
    private string name;
    private int age;

    // Constructor
    public People(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
}

public class CS20_Constructor
{
     void Main()
    {
        // Create a new person
        People person = new People("John", 30);

        // Access and modify properties
        Console.WriteLine("Initial name: " + person.Name);
        Console.WriteLine("Initial age: " + person.Age);

        person.Name = "Alice";
        person.Age = 25;

        Console.WriteLine("Modified name: " + person.Name);
        Console.WriteLine("Modified age: " + person.Age);
    }
}
