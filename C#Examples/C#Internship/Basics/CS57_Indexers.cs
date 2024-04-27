using System;

namespace Demo
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> listEmployees;

        public Company()
        {
            listEmployees = new List<Employee>();

            listEmployees.Add(new Employee
            { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 5, Name = "Emily", Gender = "Female" });
            listEmployees.Add(new Employee
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new Employee
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees
                    .FirstOrDefault(x => x.EmployeeId == employeeId)?.Name;
            }
            set
            {
                Employee employee = listEmployees
                    .FirstOrDefault(x => x.EmployeeId == employeeId);
                if (employee != null)
                {
                    employee.Name = value;
                }
            }
        }
    }

    public class CS57_Indexers
    {
        void Main()
        {
            Company company = new Company();

            string employeeName1 = company[2];
            Console.WriteLine("Employee with ID 2: " + employeeName1); // Output: "Employee with ID 2: Pam"

            company[3] = "Jane";
            string employeeName2 = company[3];
            Console.WriteLine("Employee with ID 3: " + employeeName2); // Output: "Employee with ID 3: Jane"
        }
    }
}
