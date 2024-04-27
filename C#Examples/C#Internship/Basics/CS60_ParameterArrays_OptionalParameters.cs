using System;

class CS60_ParameterArrays_OptionalParameters
{
    void Main(string[] args)
    {
        // Example of calling AddNumbers method with just two numbers
        AddNumbers(10, 20);
    }

    public static void AddNumbers(int firstNumber, int secondNumber,
                                  params object[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;
        foreach (int i in restOfTheNumbers)
        {
            result += i;
        }

        Console.WriteLine("Total = " + result.ToString());
    }
}
