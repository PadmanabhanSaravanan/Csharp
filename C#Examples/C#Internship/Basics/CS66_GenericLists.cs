public class CS66_GenericLists
{
     void Main()
    {
        // Create Customer Objects
        Customer102 customer1 = new Customer102()
        {
            ID = 101,
            Name = "Mark",
            Salary = 4000,
            Type = "RetailCustomer"
        };

        Customer102 customer2 = new Customer102()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000,
            Type = "RetailCustomer"
        };

        Customer102 customer3 = new Customer102()
        {
            ID = 103,
            Name = "Rob",
            Salary = 5500,
            Type = "RetailCustomer"
        };

        Customer102 customer4 = new Customer102()
        {
            ID = 104,
            Name = "John",
            Salary = 6500,
            Type = "CorporateCustomer"
        };

        Customer102 customer5 = new Customer102()
        {
            ID = 105,
            Name = "Sam",
            Salary = 3500,
            Type = "CorporateCustomer"
        };


        List<Customer102> listCustomers = new List<Customer102>();
        // Add() method allows you to add one at a time to the end of the list
        listCustomers.Add(customer1);
        listCustomers.Add(customer2);
        listCustomers.Add(customer3);

        List<Customer102> listCorporateCustomers = new List<Customer102>();
        listCorporateCustomers.Add(customer4);
        listCorporateCustomers.Add(customer5);

        // AddRange() allows you to add another list of items, to the end of the list
        listCustomers.AddRange(listCorporateCustomers);

        foreach (Customer102 customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // GetRange() function returns a list of items from the list.
        List<Customer102> corporateCustomers = listCustomers.GetRange(3, 2);
        foreach (Customer102 customer in corporateCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // Remove() function removes only the first matching item from the list.
        listCustomers.Remove(customer1);

        // RemoveAt() function, removes the item at the specified index in the list.
        listCustomers.RemoveAt(0);

        // RemoveAll() function removes all the items that matches the specified condition.
        listCustomers.RemoveAll(x => x.Type == "RetailCustomer");

        foreach (Customer102 customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // RemoveRange() method removes a range of elements from the list.
        // This function expects 2 parameters, i.e the start index in the
        // list and the number of elements to remove.
        listCustomers.RemoveRange(0, 2);

        // Insert() method allows you to insert a single item at a time into
        // the list at a specificed index
        listCustomers.Insert(0, customer1);
        listCustomers.Insert(1, customer2);
        listCustomers.Insert(2, customer3);

        // InsertRange() allows you, to insert another list of items to your list at the specified index
        listCustomers.InsertRange(0, listCorporateCustomers);

        foreach (Customer102 customer in listCustomers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                customer.ID, customer.Name, customer.Salary, customer.Type);
        }
        Console.WriteLine("------------------------------------------------------");

        // If you want to remove all the elements from the list without specifying
        // any condition, then use Clear() function.
        listCustomers.Clear();

        Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
    }
}

public class Customer102
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Type { get; set; }
}
