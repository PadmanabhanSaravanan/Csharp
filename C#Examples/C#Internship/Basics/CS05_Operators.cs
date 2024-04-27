using System;

class CS05_Operators
{
     void Main()
    {
        // Declare and initialize some variables
        int a = 5, b = 10;
        bool isTrue = true;

        // Perform some arithmetic operations
        int sum = a + b;
        int difference = b - a;
        int product = a * b;
        int quotient = b / a;
        int remainder = b % a;

        // Use comparison and logical operators
        bool isEqual = (a == b);
        bool isGreater = (a > b);
        bool isTrueOrGreater = (isTrue || isGreater);

        // Use assignment and increment operators
        a += 1;
        b -= 1;
        a++;
        b--;

        // Output the results
        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Difference: {0}", difference);
        Console.WriteLine("Product: {0}", product);
        Console.WriteLine("Quotient: {0}", quotient);
        Console.WriteLine("Remainder: {0}", remainder);
        Console.WriteLine("Is a equal to b? {0}", isEqual);
        Console.WriteLine("Is a greater than b? {0}", isGreater);
        Console.WriteLine("Is true or greater? {0}", isTrueOrGreater);
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
    }
}