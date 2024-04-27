using System;

public class Person1
{
    private string name;
    private int age;

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

class CS28_Properties
{
     void Main(string[] args)
    {
        Person1 person = new Person1();
        person.Name = "Alice";
        person.Age = 30;

        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}
