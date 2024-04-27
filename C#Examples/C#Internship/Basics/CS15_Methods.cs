using System;

public class MathUtils //Static Method
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
}

public class Person //Instance Method
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hello, my name is {Name}");
    }
}

public class CS15_Methods
{
     void Main()
    {
        // Calling the static method from MathUtils
        int result = MathUtils.Add(3, 5);
        Console.WriteLine($"Result of adding 3 and 5: {result}");

        // Creating an instance of the Person class
        Person person = new Person();
        person.Name = "John";

        // Calling the instance method of Person
        person.SayHello();
    }
}
