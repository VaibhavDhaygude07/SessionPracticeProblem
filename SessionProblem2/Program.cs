using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SessionProblem2
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int salary { get; set; }
        public DateTime dateOfJoining{get;set;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)Given a list of employees with properties like ID, Name, Department, Salary, and DateOfJoining, write queries to:
            //Find employees who joined after a specific date.
            //Calculate the average salary of employees in each department.
            //Group employees by department and list their names.
            //Find the top 3 highest - paid employees using Lambda and LINQ.

            List<Employee> employee = new List<Employee> { 
                new Employee {id=101, name="vaibhav", department="IT",        salary=65000, dateOfJoining =new DateTime(2021, 5, 21) },
                new Employee {id=102, name="Ravi",    department="sales",     salary=45000, dateOfJoining = new DateTime(2020, 1, 15)},
                new Employee {id=103, name="Naveen",  department="IT",        salary=55000, dateOfJoining= new DateTime(2020, 6, 7)},
                new Employee {id=104, name="Maninsh", department="Devlopment",salary=45000, dateOfJoining= new DateTime(2022,7,7)},
                new Employee {id=105, name="Aryan",   department="IT",        salary=35000, dateOfJoining=new DateTime(2020,4,24)},
                new Employee {id=106, name="Ajay" ,   department="sales",     salary=27000, dateOfJoining= new DateTime(2023,12,22)},
                new Employee {id=107, name="Amar" ,   department="IT",        salary=45000, dateOfJoining= new DateTime(2020,11,22)},
                new Employee {id=108, name="Nikhil" , department="sales",     salary=25000, dateOfJoining= new DateTime(2021,9,22)},
                new Employee {id=109, name="Saurabh" ,department="IT",        salary=45000, dateOfJoining= new DateTime(2022,1,22)},
                new Employee {id=110, name="Prathmesh",department="Devlopment",salary=60000, dateOfJoining= new DateTime(2023,7,22)},
                new Employee {id=111, name="Suraj" ,   department="sales",     salary=40000, dateOfJoining= new DateTime(2021,6,22)},
                new Employee {id=112, name="Santosh" ,department="Devlopment", salary=33000, dateOfJoining= new DateTime(2020,3,22)}

            };

            var joining = from emp in employee
                          where emp.dateOfJoining > new DateTime(2021, 5, 20)
                          select emp;


            foreach (var emp in joining)
            {
                Console.WriteLine($"Name: {emp.name}, DateOfJoining: {emp.dateOfJoining}");
            }

            // Calculate the average salary of employees in each department.
            var groupByDept = from emp in employee
                              group emp by emp.department into deptGroup
                              select new
                              {
                                  department = deptGroup.Key,
                                  AverageSalary = deptGroup.Average(e => e.salary)
                              };
            foreach (var emp in groupByDept)
            {
                Console.WriteLine($"Department: {emp.department}, Average Salary: {emp.AverageSalary}");
            }

            //Group employees by department and list their names.
            var groupBY = from emp in employee
                          group emp by emp.department into deptmentGroup
                          select deptmentGroup;
            foreach (var dept in groupBY)
            {
                Console.WriteLine($"Department name: {dept.Key}");
                foreach (var emp in dept)
                {
                    Console.WriteLine($"Name: {emp.name}");
                }
            }

            //Find the top 3 highest - paid employees using Lambda and LINQ.
            var empSalary = (from emp in employee
                             orderby emp.salary descending
                             select emp).Take(3);

            foreach(var emp in empSalary)
            {
                Console.WriteLine($"ID: {emp.id}, name: {emp.name}, Department: {emp.department}, Salary: {emp.salary}");
            }

                             




        }
    }
}
