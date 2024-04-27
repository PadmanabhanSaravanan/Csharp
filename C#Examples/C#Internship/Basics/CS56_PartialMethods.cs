using System;

class CS56_PartialMethods
{
     void Main(string[] args)
    {
        SampleClass SC = new SampleClass();
        SC.PublicMethod();
    }
}

partial class SampleClass
{
    // Public method calling the partial method
    public void PublicMethod()
    {
        // Check if the partial method is implemented
        SampleMethod();
    }

    // Partial method declaration
    partial void SampleMethod();
}

partial class SampleClass
{
    // Partial method implementation
    partial void SampleMethod()
    {
        Console.WriteLine("SampleMethod Implemented");
    }
}
