using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class Program
    {
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //Prime Number Checker
            //Write a console app to check if a number is prime.Implement input validation and ensure proper error handling.
            try
            {
                Console.WriteLine("Enter the number: ");
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

           

        }
    }
}
