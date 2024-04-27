using System;

public class CS16_MethodParameters
{
    public static void ValueParameter(int x)
    {
        x = x + 1;
        Console.WriteLine(x);
    }

    public static void ReferenceParameter(ref int x)
    {
        x = x + 1;
        Console.WriteLine(x);
    }

    public static void OutputParameter(int x, out int y)
    {
        y = x + 1;
        Console.WriteLine(y);
    }

    public static void ParamsParameter(params string[] names)
    {
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }

      void Main()
    {
        int value = 5;
        Console.WriteLine("Value parameter:");
        Console.WriteLine("Before method call: " + value);
        ValueParameter(value);
        Console.WriteLine("After method call: " + value);

        Console.WriteLine();

        int reference = 5;
        Console.WriteLine("Reference parameter:");
        Console.WriteLine("Before method call: " + reference);
        ReferenceParameter(ref reference);
        Console.WriteLine("After method call: " + reference);

        Console.WriteLine();

        int output;
        Console.WriteLine("Output parameter:");
        OutputParameter(5, out output);
        Console.WriteLine("Returned value: " + output);

        Console.WriteLine();

        Console.WriteLine("Params parameter:");
        ParamsParameter("John", "Mary", "David");
    }
}
