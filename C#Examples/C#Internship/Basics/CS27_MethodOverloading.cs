using System;

class Calculator
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}

class CS27_MethodOverloading
{
     void Main(string[] args)
    {
        Calculator calc = new Calculator();
        int result1 = calc.Add(5, 10);          // result1 = 15
        int result2 = calc.Add(5, 10, 15);      // result2 = 30
        double result3 = calc.Add(1.5, 2.5);    // result3 = 4.0

        Console.WriteLine($"Result1: {result1}");
        Console.WriteLine($"Result2: {result2}");
        Console.WriteLine($"Result3: {result3}");
    }
}
