using System;

class CS61_MethodOverloading_OptionalParameters
{
    void Main(string[] args)
    {
        // Example of calling AddNumbers method with just two numbers
        AddNumbers(10, 20);

        // Example of calling AddNumbers method with additional numbers
        AddNumbers(10, 20, new int[] { 30, 40, 50 });
    }

    // Method overload with three parameters
    public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfNumbers)
    {
        int result = firstNumber + secondNumber;
        if (restOfNumbers != null)
        {
            foreach (int i in restOfNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("Sum = " + result);
    }

    // Method overload with two parameters
    public static void AddNumbers(int firstNumber, int secondNumber)
    {
        AddNumbers(firstNumber, secondNumber, null); // Calls the three-parameter overload with null array
    }
}
