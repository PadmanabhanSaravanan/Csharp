using System;

class CS10_IfStatement
{
     void Main()
    {   

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote!");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote yet.");
        }

        Console.ReadLine();
    }
}
