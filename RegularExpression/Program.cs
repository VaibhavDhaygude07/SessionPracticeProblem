using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user details:");
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();

            bool isNameValid = ValidateName(name);
            if (isNameValid)
            {
                Console.WriteLine("Name is valid");
            }
            else
            {
                Console.WriteLine("Name is not valid");
            }

           
            bool isEmailValid = ValidateName(email);
            if (isEmailValid)
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }

        }

        public static bool ValidateName(string name)
        {
           
            string pattern = @"^[A-Z]{1}[a-z]{2,}$";
            return Regex.IsMatch(name, pattern);
        }

        public static bool ValidateAge(string age)
        {
            string pattern = @"^\d+$";
            if (Regex.IsMatch(age, pattern))
            {
                int ageValue = int.Parse(age);
                return ageValue >= 18 && ageValue <= 60;
            }
            return false;
        }
        public static bool ValidatateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
