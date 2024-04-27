using System.Collections.Generic;

class CS37_Delegates1
{
    void Main()
    {
        int number = 5;

        CalculateSquare(number);
        CalculateCube(number);
    }

    static void CalculateSquare(int number)
    {
        int square = number * number;
        Console.WriteLine($"Square of {number} is: {square}");
    }

    static void CalculateCube(int number)
    {
        int cube = number * number * number;
        Console.WriteLine($"Cube of {number} is: {cube}");
    }
}