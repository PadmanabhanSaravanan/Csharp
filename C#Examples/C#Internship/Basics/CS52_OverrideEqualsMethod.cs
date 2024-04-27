using System;

public class Person111
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person111 otherPerson = (Person111)obj;
        return Name == otherPerson.Name && Age == otherPerson.Age;
    }

    public override int GetHashCode()
    {
        // Implement a custom GetHashCode() method for consistency with Equals()
        return (Name.GetHashCode() * 397) ^ Age.GetHashCode();
    }
}

class CS52_OverrideEqualsMethod
{
    // Example usage:
     void Main(string[] args)
    {
        Person111 person1 = new Person111 { Name = "Alice", Age = 30 };
        Person111 person2 = new Person111 { Name = "Alice", Age = 30 };
        Person111 person3 = new Person111 { Name = "Bob", Age = 25 };

        // Testing equality
        Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}"); // true
        Console.WriteLine($"person1.Equals(person3): {person1.Equals(person3)}"); // false

        // Testing GetHashCode()
        Console.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}"); // Same as person2.GetHashCode()
        Console.WriteLine($"person3.GetHashCode(): {person3.GetHashCode()}"); // Should be different from person1.GetHashCode()
    }
}