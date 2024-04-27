using System;
using System.Collections.Generic;

public class CS70_ListMethods
{
    void Main()
    {
        Customer101 customer1 = new Customer101()
        {
            ID = 101,
            Name = "Mark",
            Salary = 5200
        };

        Customer101 customer2 = new Customer101()
        {
            ID = 103,
            Name = "John",
            Salary = 7000
        };

        Customer101 customer3 = new Customer101()
        {
            ID = 102,
            Name = "Ken",
            Salary = 5500
        };

        List<Customer101> listCustomers = new List<Customer101>();
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        Console.WriteLine("Are all salaries greater than 5000: " +
            listCustomers.TrueForAll(x => x.Salary > 5000));

        // ReadOnlyCollection will not have Add() or Remove() methods
        System.Collections.ObjectModel.ReadOnlyCollection<Customer101> readOnlyCustomers = listCustomers.AsReadOnly();

        Console.WriteLine("Total Items in ReadOnlyCollection = " +
            readOnlyCustomers.Count);

        // listCustomers list is created with an initial capacity based on the number of elements added
        // but it can be trimmed if needed.
        Console.WriteLine("List capacity before invoking TrimExcess = " +
                listCustomers.Capacity);
        // Invoke TrimExcess() to set the capacity to the actual number of elements in the List
        listCustomers.TrimExcess();
        Console.WriteLine("List capacity after invoking TrimExcess = " +
                listCustomers.Capacity);
    }
}

public class Customer101
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
