using System;

class CS02_ReadingandWritingToConsole
{
         void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:");
        string name = "John";
        int age = 30;
        Console.WriteLine("Hello, " + name + "!");

        Console.WriteLine("Hello, " + name + ". You are " + age + " years old.");

        Console.WriteLine($"Hello, {name}. You are {age} years old.");
    }
}
