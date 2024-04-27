using System;

class CS40_ExceptionHandling
{
    void Main(string[] args)
    {
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator; // Division by zero, will throw an exception
            Console.WriteLine("Result: " + result); // This line will not be reached
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Cleanup operations");
        }
    }
}
