using System;

class CS41_InnerException
{
     void Main(string[] args)
    {
        try
        {
            try
            {
                // Some code that may throw an exception
                throw new ArgumentException("Invalid argument");
            }
            catch (Exception ex)
            {
                // Wrap the caught exception with a new exception
                throw new InvalidOperationException("Operation failed", ex);
            }
        }
        catch (Exception ex)
        {
            // Display the exception details, including inner exceptions
            Console.WriteLine("Exception: " + ex.Message);
            Console.WriteLine("Inner Exception: " + ex.InnerException?.Message);
        }
    }
}
