using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProblem
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public int salary { get; set; }
        public DateTime dateOfJoining { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
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
                new Employee {id=112, name="Santosh" ,department="Devlopment", salary=33000, dateOfJoining= new DateTime(2020,3,22)},
                new Employee {id=101, name="vaibhav", department="IT",        salary=65000, dateOfJoining =new DateTime(2021, 5, 21)},
                new Employee {id=106, name="Ajay" ,   department="sales",     salary=27000, dateOfJoining= new DateTime(2023,12,22)},
                new Employee {id=107, name="Amar" ,   department="IT",        salary=45000, dateOfJoining= new DateTime(2020,11,22)},
                new Employee {id=108, name="Nikhil" , department="sales",     salary=25000, dateOfJoining= new DateTime(2021,9,22)},
                new Employee {id=109, name="Saurabh" ,department="IT",        salary=45000, dateOfJoining= new DateTime(2022,1,22)},
                new Employee {id=110, name="Prathmesh",department="Devlopment",salary=60000, dateOfJoining= new DateTime(2023,7,22)},

            };

            IEnumerable<string> names = employees.Select(fName => fName.name).Distinct();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            employees.ForEach(emp => Console.WriteLine($"Name {emp.name}, Department: {emp.department}"));

           var employee = from a in employees
                        where a.salary > 35000
                        select a;

            foreach(var salary in employee)
            {
                Console.WriteLine($"Name: {salary.name},Salary: {salary.salary}");
            }

            PracticeProblem.Linq();
        }
    }
}
