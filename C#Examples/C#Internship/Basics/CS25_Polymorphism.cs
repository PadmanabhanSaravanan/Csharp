using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof");
    }
}

class CS25_Polymorphism
{
      void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.Speak(); // Output: Animal speaks

        Animal myCat = new Cat();
        myCat.Speak(); // Output: Meow

        Animal myDog = new Dog();
        myDog.Speak(); // Output: Woof
    }
}
