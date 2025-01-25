using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation
{
    //name, email, age, gender,phonenumber,zip code
    
    public class PeopleInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int ZipCode { get; set; }
    }
    internal class Program
    {
        public static bool isValid;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user details ");
            Console.WriteLine("Enter user name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter user age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter gender: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter zip code:");
            int zipCode = int.Parse(Console.ReadLine());

            var people = new PeopleInfo
            {
                Name = name,
                Age = age,
                Email = email,
                Gender = gender,
                PhoneNumber = phoneNumber,
                ZipCode = zipCode
            };

            var context = new ValidationContext(people);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(people, context, results,  true);
            if (isValid)
            {
                Console.WriteLine("User data is valid");
            }
            else
            {
                Console.WriteLine("Validation error");
                foreach (var error in results)
                {
                    Console.WriteLine($"-{error.ErrorMessage}");
                }
            }

        }
    }
}
