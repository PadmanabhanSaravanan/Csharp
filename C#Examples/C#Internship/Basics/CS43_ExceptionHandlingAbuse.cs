using System;

class CS43_ExceptionHandlingAbuse
{
    void Main(string[] args)
    {
        try
        {
            // Proper exception handling
            int dividend = 10;
            int divisor = 0;

            if (divisor == 0)
            {
                throw new ArgumentException("Divisor cannot be zero.");
            }

            int result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        catch (ArgumentException ex)
        {
            // Properly handle the specific exception
            Console.WriteLine("ArgumentException: " + ex.Message);
        }
        catch (Exception ex)
        {   
            // Handle other exceptions
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
            // Perform cleanup operations
            Console.WriteLine("Cleanup operations");
        }

        try
        {
            // Exception handling abuse
            int[] numbers = { 1, 2, 3 };
            for (int i = 0; i <= numbers.Length; i++)
            {
                try
                {
                    int value = numbers[i];
                    Console.WriteLine("Value: " + value);
                }
                catch (IndexOutOfRangeException)
                {
                    // Swallow the exception and continue the loop
                }
            }
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            Console.WriteLine("Exception: " + ex.Message);
        }
        finally
        {
            // Perform cleanup operations
            Console.WriteLine("Cleanup operations");
        }
    }
}
