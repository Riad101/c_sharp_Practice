using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practice
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }

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
                AnnualSalary = 60000
            },
            new Employee
            {
                EmployeeID = 102,
                FirstName = "Mike",
                LastName = "Mist",
                Gender = "Male",
                AnnualSalary = 72000
            },
            new Employee
            {
                EmployeeID = 103,
                FirstName = "Mary",
                LastName = "Lambeth",
                Gender = "Female",
                AnnualSalary = 48000
            },
            new Employee
            {
                EmployeeID = 104,
                FirstName = "Pam",
                LastName = "Penny",
                Gender = "Female",
                AnnualSalary = 84000
            },
        };

            return listEmployees;
        }
    }

    static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { Make = "Marcedez", Model = "i50l", VIN = "A5", Year= 2010},
                new Car() { Make = "Ford", Model = "4Runner", VIN = "F6" , Year= 2013},
                new Car() { Make = "BMW", Model = "750li", VIN = "C3" , Year= 2015},
                new Car() { Make = "BMW", Model = "550li", VIN = "B2" , Year= 2018},
                new Car() { Make = "Audi", Model = "E50li", VIN = "D4", Year= 2020},
                new Car() { Make = "BMW", Model = "745li", VIN = "E5" , Year= 2021}
            };

            //Linq query

            /*var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2020
                       select car;
            */

            /* var orderCar = from car in myCars
                           orderby car.Year descending
                           select car;
            */

            //linq method
            //var bmws = myCars.Where(p => p.Make == "BMW");

            //var orderCar = myCars.OrderByDescending(p => p.Year);

            //var firstBMW = myCars.OrderByDescending(p=> p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            //Console.WriteLine(myCars.TrueForAll(p=> p.Year > 2009));


            //foreach (var car in orderCar)
            //{
            //    Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            //}

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers
                 .Select((num, index) => new { Number = num, Index = index })
                 .Where(X => X.Number % 2 == 0)
                 .Select(X=> X.Index);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    
}
