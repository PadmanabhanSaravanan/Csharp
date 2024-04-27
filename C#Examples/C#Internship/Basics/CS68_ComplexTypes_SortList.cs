using System;
using System.Collections.Generic;

public class CS68_ComplexTypes_SortList
{
     void Main()
    {
        Customer104 customer1 = new Customer104()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000
        };

        Customer104 customer2 = new Customer104()
        {
            ID = 102,
            Name = "John",
            Salary = 7000
        };

        Customer104 customer3 = new Customer104()
        {
            ID = 103,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer104> listCustomers = new List<Customer104>();
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer104 customer in listCustomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // Sort() method should sort customers by salary
        listCustomers.Sort();

        Console.WriteLine("Customers after sorting by Salary");
        foreach (Customer104 customer in listCustomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }

        // To sort customers by name instead of salary
        listCustomers.Sort(new SortByName());

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer104 customer in listCustomers)
        {
            Console.WriteLine(customer.Name + " - " + customer.Salary);
        }
    }
}

public class Customer104 : IComparable<Customer104>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Customer104 other)
    {
        // Compare customers by salary
        return this.Salary.CompareTo(other.Salary);
    }
}

public class SortByName : IComparer<Customer104>
{
    public int Compare(Customer104 x, Customer104 y)
    {
        // Compare customers by name
        return x.Name.CompareTo(y.Name);
    }
}
