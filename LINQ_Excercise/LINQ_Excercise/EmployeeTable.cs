using System.Collections.Generic;

namespace LINQ_Excercise
{
    public class EmployeeTable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public static List<EmployeeTable> GetAllEmployeeTable()
        {
            return new List<EmployeeTable>()
        {
            new EmployeeTable{ ID = 1, Name = "Mark", DepartmentID = 1 },
            new EmployeeTable{ ID = 2, Name = "Steve", DepartmentID = 2 },
            new EmployeeTable{ ID = 3, Name = "Ben", DepartmentID = 1 },
            new EmployeeTable{ ID = 4, Name = "Philip", DepartmentID = 1 },
            new EmployeeTable{ ID = 5, Name = "Mary", DepartmentID = 2 },
            new EmployeeTable{ ID = 6, Name = "Valarie", DepartmentID = 2 },
            new EmployeeTable{ ID = 7, Name = "John", DepartmentID = 1 },
            new EmployeeTable{ ID = 8, Name = "Pam", DepartmentID = 1 },
            new EmployeeTable{ ID = 9, Name = "Stacey", DepartmentID = 2 },
            new EmployeeTable{ ID = 10, Name = "Andy", DepartmentID = 1}
        };
        }
    }
}
