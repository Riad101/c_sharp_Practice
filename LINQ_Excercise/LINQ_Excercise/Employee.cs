using System.Collections.Generic;

namespace LINQ_Excercise
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
        public string Department { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
        {
            new Employee
            {
                EmployeeID = 101,
                FirstName = "Tom",
                LastName = "Daely",
                Gender = "Male",
                AnnualSalary = 60000,
                JobTitle = "Sr.Developer",
                City = "London",
                Department = "IT"
            },
            new Employee
            {
                EmployeeID = 102,
                FirstName = "Mike",
                LastName = "Mist",
                Gender = "Male",
                AnnualSalary = 72000,
                JobTitle = "Sr.Developer",
                City = "London",
                Department = "IT"
            },
            new Employee
            {
                EmployeeID = 103,
                FirstName = "Mary",
                LastName = "Lambeth",
                Gender = "Female",
                AnnualSalary = 48000,
                JobTitle = "Developer",
                City = "Calgary",
                Department = "IT"
            },
            new Employee
            {
                EmployeeID = 104,
                FirstName = "Pam",
                LastName = "Penny",
                Gender = "Female",
                AnnualSalary = 84000,
                JobTitle = "Sr.Developer",
                City = "London",
                Department = "IT"
            },
            new Employee
            {
                EmployeeID = 105,
                FirstName = "Pamy",
                LastName = "Penn",
                Gender = "Female",
                AnnualSalary = 85000,
                JobTitle = "Sr.Executive",
                City = "Calgary",
                Department = "HR"
            },
            new Employee
            {
                EmployeeID = 107,
                FirstName = "John",
                LastName = "Smith",
                Gender = "Female",
                AnnualSalary = 45000,
                JobTitle = "Developer",
                City = "Calgary",
                Department = "IT"
            },

            new Employee
            {
                EmployeeID = 108,
                FirstName = "Sam",
                LastName = "Penn",
                Gender = "Male",
                AnnualSalary = 75000,
                JobTitle = "Sr.Executive",
                City = "Toronto",
                Department = "HR"
            },

            new Employee
            {
                EmployeeID = 109,
                FirstName = "Harry",
                LastName = "Penn",
                Gender = "Male",
                AnnualSalary = 55000,
                JobTitle = "Executive",
                City = "Toronto",
                Department = "HR"
            },

            new Employee
            {
                EmployeeID = 110,
                FirstName = "Joey",
                LastName = "Potter",
                Gender = "Female",
                AnnualSalary = 60000,
                JobTitle = "Executive",
                City = "Toronto",
                Department = "HR"
            },

        };

            return listEmployees;
        }
    }
}
