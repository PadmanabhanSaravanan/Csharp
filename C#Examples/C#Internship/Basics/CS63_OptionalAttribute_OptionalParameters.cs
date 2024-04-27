using System;
using System.Runtime.InteropServices;

class CS63_OptionalAttribute_OptionalParameters
{
    void Main(string[] args)
    {
        // Example of calling AddNumbers method with just two numbers
        AddNumbers(10, 20);

        // Example of calling AddNumbers method with additional numbers
        AddNumbers(10, 20, new int[] { 30, 40, 50 });
    }

    // Method with optional parameter specified using OptionalAttribute
    public static void AddNumbers(int firstNumber, int secondNumber,
                                  [Optional] int[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;

        // Loop through restOfTheNumbers only if it is not null
        // Otherwise, you will get a null reference exception
        if (restOfTheNumbers != null)
        {
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
        }

        Console.WriteLine("Total1 = " + result);
    }
}
