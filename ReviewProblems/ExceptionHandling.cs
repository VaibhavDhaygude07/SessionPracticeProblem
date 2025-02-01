using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message)
        {
            Console.WriteLine(message);
        }
    

        public static void Exception()
        {

            //Create a custom exception InvalidAgeException that is thrown when a user enters an age less than 18.
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new InvalidAgeException("Enter valid age ");
                }
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }





        }
    }
}
