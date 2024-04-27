using System;

public class CustomException : Exception
{
    public CustomException()
    {
    }

    public CustomException(string message)
        : base(message)
    {
    }

    public CustomException(string message, Exception innerException)
       : base(message, innerException)
    {
    }
}

class CS42_CustomException
{
     void Main(string[] args)
    {
        try
        {
            // Some code that may throw a custom exception
            throw new CustomException("Custom exception occurred");
        }
        catch (CustomException ex)
        {
            // Handle the custom exception
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            Console.WriteLine("Exception: " + ex.Message);
        }
    }
}
