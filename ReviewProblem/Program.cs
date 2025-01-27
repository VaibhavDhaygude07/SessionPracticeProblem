using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes two integers and divides them.
            //Handle exceptions for:
            //Division by zero.
            //Invalid input format.

            try
                {
                Console.WriteLine("Enter first number:");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int result = number / divisor;
                Console.WriteLine(" Result : " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero.");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format.");
            }



            //Custom Age Validator
            //Write a program to input the age of a person.
            //Throw an exception if the age is less than 0 or greater than 150.

            Console.WriteLine("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age < 0 || age > 150)
                {
                    throw new Exception("Invalid age.");
                }
                else
                {
                    Console.WriteLine("Age is valid.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
