using System;

class CS07_DataTypeConversions
{
     void Main()
    {
        int myInt = 42;
        double myDouble = myInt;  // Implicit conversion from int to double
        Console.WriteLine("Converted from int to double: " + myDouble); // Corrected WriteLine statement

        double myDouble1 = 3.14;
        int myInt1 = (int)myDouble1;  // Explicit conversion from double to int
        int myInt2 = Convert.ToInt16(myDouble1);
        Console.WriteLine("Converted from double to int: " + myInt1); // Corrected WriteLine statement
    }
}
