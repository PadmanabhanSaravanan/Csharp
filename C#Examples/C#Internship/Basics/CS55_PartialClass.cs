using System;

public partial class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

public partial class Customer
{
    public bool IsValid()
    {
        // Validation logic for the Customer class
        return !string.IsNullOrEmpty(Name);
    }
}

class CS55_PartialClass
{
    void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.Name = "John Doe";

        bool isValid = customer.IsValid(); // Returns true
        Console.WriteLine($"Is Valid: {isValid}");

        customer.Name = "";
        isValid = customer.IsValid(); // Returns false
        Console.WriteLine($"Is Valid: {isValid}");
    }
}
