using System.Collections.Generic;

delegate int Calculation(int number);
class CS35_Delegates2
{
     void Main()
    {
        int number = 5;

        Calculation squareCalculation = Square;
        Calculation cubeCalculation = Cube;

        PerformCalculation(number, squareCalculation);
        PerformCalculation(number, cubeCalculation);
    }

    static void PerformCalculation(int number, Calculation calculation)
    {
        int result = calculation(number);
        Console.WriteLine($"Result: {result}");
    }

    static int Square(int number)
    {
        return number * number;
    }

    static int Cube(int number)
    {
        return number * number * number;
    }
}