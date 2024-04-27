using System;


// Type: Person
class Person11
{
    // Type member: Field
    private string name;

    // Type member: Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Type member: Method
    public void SayHello1()
    {
        Console.WriteLine("Hello, my name is " + name);
    }
}
class CS45_TypeVSTypeMembers
{
     void Main()
    {
        // Creating an instance of the Person type
        Person11 person = new Person11();

        // Accessing the type member 'Name' through the instance
        person.Name = "John Doe";

        // Accessing the type member 'SayHello' through the instance
        person.SayHello1();
    }
}
