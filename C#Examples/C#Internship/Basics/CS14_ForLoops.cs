using System;

class CS14_ForLoops
{
     void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Using a for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nUsing a foreach loop:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}
