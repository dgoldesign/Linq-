using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class LearningLink
    {
        Department department = new Department();
        Employee employee = new Employee();
        public void ManipulateLinq()
        {
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {Id = 1, Name ="Winner", Department = "Music", salary = 50000},
                new Employee {Id = 2, Name ="Brandon", Department = "Game", salary = 40000},
                new Employee {Id = 3, Name ="MaryAnn", Department = "business", salary = 20000},
                new Employee {Id = 4, Name ="Mara", Department = "cooking", salary = 10000},
                new Employee {Id = 5, Name ="Micheal", Department = "Music", salary = 90000},
                new Employee {Id = 6, Name ="NG", Department = "Tech", salary = 10000000}
            };

            var musicEmployees = employees.Where(emp => emp.Department == "Music"); //this is your linq
            Console.WriteLine("The employees in the Music department are : ");
            foreach (var musicemployee in musicEmployees)
            {
                
                Console.WriteLine(musicemployee.Name);
            }

            Console.WriteLine("The employees and there salaries are : ");
            var employeeSalaries = employees.OrderBy(emp => emp.salary); //this is your linq
            foreach(var employeeSalary in employeeSalaries)
            {
                Console.WriteLine($"{employeeSalary.Name} : {employeeSalary.salary}");
            }

            IEnumerable<Department> departments = new List<Department>()
            {
                new Department {Id = 1, Name ="Music"},
                new Department {Id = 2, Name ="Business"},
                new Department {Id = 3, Name ="Game"},

            };

            var joinEmployeesAndDepartments = employees.Join(
                departments,
                emp => emp.Department,
                dept => dept.Name,
                (emp, dept) => new{ emp.Department, dept.Name});
            Console.WriteLine("The join for the Employee and Departments are:");
            foreach(var joinemployeedept in joinEmployeesAndDepartments)
            {
                Console.WriteLine($"{joinemployeedept.Name} : {joinemployeedept.Department}");
            }

        }
    }
}
