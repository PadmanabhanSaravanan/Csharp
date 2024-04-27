using System;

interface IAnimal
{
    void Eat();
}

class Animals1 : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

interface ICanFly
{
    void Fly();
}

class Bird : ICanFly
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}

class Pegasus : IAnimal, ICanFly
{
    private Animals1 animal = new Animals1();
    private Bird bird = new Bird();

    public void Eat()
    {
        animal.Eat();
    }

    public void Fly()
    {
        bird.Fly();
    }
}

class CS35_MultipleInheritance
{
     void Main(string[] args)
    {
        Pegasus pegasus = new Pegasus();
        pegasus.Eat(); // Output: The animal is eating.
        pegasus.Fly(); // Output: The bird is flying.
    }
}
