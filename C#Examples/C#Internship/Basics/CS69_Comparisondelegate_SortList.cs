using System;
using System.Collections.Generic;

public class CS69_Comparisondelegate_SortList
{
    void Main()
    {
        Customer105 customer1 = new Customer105()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer105 customer2 = new Customer105()
        {
            ID = 103,
            Name = "John",
            Salary = 7000
        };

        Customer105 customer3 = new Customer105()
        {
            ID = 102,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer105> listCustomers = new List<Customer105>();
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer105 customer in listCustomers)
        {
            Console.WriteLine(customer.ID);
        }

        // Sorting using lambda expression
        listCustomers.Sort((x, y) => x.ID.CompareTo(y.ID));

        Console.WriteLine("Customers after sorting by ID");
        foreach (Customer105 customer in listCustomers)
        {
            Console.WriteLine(customer.ID);
        }

        // Reverse the list to get descending order
        listCustomers.Reverse();
        Console.WriteLine("Customers in descending order of ID");
        foreach (Customer105 customer in listCustomers)
        {
            Console.WriteLine(customer.ID);
        }
    }
}

public class Customer105
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
