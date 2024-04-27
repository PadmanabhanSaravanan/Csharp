using System;

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class CS44_Enums 
{
     void Main()
    {
        // Using enum in code
        DaysOfWeek today = DaysOfWeek.Monday;
        Console.WriteLine("Today is " + today);

        // Enum comparison
        if (today == DaysOfWeek.Saturday || today == DaysOfWeek.Sunday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }

        // Enum iteration
        Console.WriteLine("All days of the week:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            Console.WriteLine(day);
        }
    }
}
