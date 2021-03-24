using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Excercise
{

    class Program
    {
        static void Main(string[] args)
        {
            //Retrieves just the EmployeeID property of all employees
            var employeeIDs = Employee.GetAllEmployees()
                .Select(emp => emp.EmployeeID);

            //foreach (var id in employeeIDs)
            //{
            //    Console.WriteLine(id);
            //}

            //Projects FirstName & Gender properties of all employees into anonymous type.

            var result = Employee.GetAllEmployees()
                .Select(emp => new { fName = emp.FirstName, Gender = emp.Gender });

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i.fName+ " "+ i.Gender);
            //}

            //Computes FullName and MonthlySalary of all employees and projects these 2 new
            //computed properties into anonymous type.

            var employeeDetails = Employee.GetAllEmployees()
                .Select(emp => new 
                { FullName = emp.FirstName + " " + emp.LastName, 
                  MonthlySalary = emp.AnnualSalary / 12 });

            //foreach (var i in employeeDetails)
            //{
            //    Console.WriteLine(i.FullName + "-" + i.MonthlySalary);
            //}

            //Give 10% bonus to all employees whose annual salary is greater than 50000
            //and project all such employee's FirstName, AnnualSalary and Bonus into anonymous type.

            var bonusEmployee = Employee.GetAllEmployees()
                .Where(emp => emp.AnnualSalary > 50000)
                .Select(emp => new 
                { 
                  Name = emp.FirstName,
                  Salary = emp.AnnualSalary,
                  bonus = emp.AnnualSalary * .10 
                });

            //foreach (var i in bonusEmployee)
            //{
            //    Console.WriteLine(i.Name + "-" + i.Salary + "-"  +i.bonus);
            //}

            //Selects student name along with all the subjects
            var studentDetails = Student.GetAllStudetns()
                .SelectMany(s => (s.Subjects), (student, subject) => new 
                { studentName = student.Name, Subject = subject });

            //foreach (var i in studentDetails)
            //{
            //    Console.WriteLine(i.studentName + " " + i.Subject);
            //}
            //var studentMark = StudentMarks.GetAllStudetnMarks()
            //    .OrderBy(s => s.TotalMarks).ThenBy(s => s.SName).ThenByDescending(s => s.StudentID);

            //foreach (var i in studentMark)
            //{
            //    Console.WriteLine(i.StudentID + "-" + i.SName + " " + i.TotalMarks);
            //}


            //List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            //var result1 = countries.ToArray().OrderByDescending(s => s);

            //foreach (var str in result1)
            //{
            //    Console.WriteLine(str);
            //}

            //ToLookUp
            var employeeByTitle = Employee.GetAllEmployees().ToLookup(s => s.JobTitle);

            Console.WriteLine("Employees Grouped By JobTitle");
            foreach (var kvp in employeeByTitle)
            {
                Console.WriteLine(kvp.Key);
                // Lookup employees by JobTitle
                foreach (var item in employeeByTitle[kvp.Key])
                {
                    Console.WriteLine("\t" + item.FirstName + "\t" + item.JobTitle + "\t" + item.City);
                }
            }

            var employeeByCIty = Employee.GetAllEmployees().ToLookup(s => s.City);

            Console.WriteLine("Employees Grouped By City Location");
            foreach (var kvpCity in employeeByCIty)
            {
                Console.WriteLine(kvpCity.Key);
                foreach (var i in employeeByCIty[kvpCity.Key])
                {
                    Console.WriteLine("\t" + i.FirstName + "\t" + i.JobTitle + "\t" + i.City);
                }
            }

            //GroupBy
            var employeeGroup = Employee.GetAllEmployees().GroupBy(x => x.Department);
            foreach (var group in employeeGroup)
            {
                Console.WriteLine("{0}-{1}", group.Key, group.Count());
                //Console.WriteLine("{0}-{1}", group.Key, group.Max(s=>s.AnnualSalary));
                Console.WriteLine("-------------------");
                foreach (var i in group)
                {
                    Console.WriteLine(i.FirstName + "\t" + i.Department);
                }
                Console.WriteLine(); Console.WriteLine();
            }

            var EmployeeGroups = Employee.GetAllEmployees()
                .GroupBy(x => new { x.Department, x.Gender })
                .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                .Select(g => new
                {
                    Dept = g.Key.Department,
                    Gender = g.Key.Gender,
                    Employee = g.OrderBy(a=> a.FirstName)
                });
            foreach (var group in EmployeeGroups)
            {
                Console.WriteLine("{0} Department {1} employee count= {2}", 
                    group.Dept, group.Gender, group.Employee.Count());
                Console.WriteLine("-------------------------------");
                foreach (var n in group.Employee)
                {
                    Console.WriteLine(n.FirstName + "\t" + n.Gender + "\t" + n.Department);
                    
                }
                Console.WriteLine(); Console.WriteLine();
            }

            //GroupJoin
            var employeeByDepartment = Department.GetAllDepartments()
                                        .GroupJoin(EmployeeTable.GetAllEmployeeTable(),
                                        d=> d.ID,
                                        e=> e.DepartmentID,
                                        (dept, emp) => new
                                        {
                                            Department = dept,
                                            EmployeeTable = emp
                                        });

            foreach (var dept in employeeByDepartment)
            {
                Console.WriteLine(dept.Department.Name);
                foreach (var emp in dept.EmployeeTable)
                {
                    Console.WriteLine(" " + emp.Name);
                }
                Console.WriteLine();
            }



        }
    }
}
