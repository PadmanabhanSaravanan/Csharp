using System;

class CS04_StringType
{
     void Main()
    {
        string Name = @"Hello,
World!";
        Console.WriteLine(Name);

        // Escape Sequence

        string Name1 = "Hello,\nWorld!";
        Console.WriteLine("Escape Sequence :" + Name1);
    }
}
