using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
    }
    internal class Program
    {
        private static bool isValid;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter user details ");
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();

            var person = new Person1
            {
                Name = name,
                Age = age,
                Email = email
            };

            var context = new ValidationContext(person);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(person, context, results, true);
            if (isValid)
            {
                Console.WriteLine("User data is valid");
            }
            else
            {
                Console.WriteLine("Validation error");
                foreach(var error in results)
                {
                    Console.WriteLine($"-{error.ErrorMessage}");
                }
            }

        }
    }
}
