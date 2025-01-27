using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem
{
    internal class EvenOddCheker
    {
        public static void EvenOdd()
        {
            // Create a lambda expression that checks whether a number is even or odd.

            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            var evenOddChecker = new Func<int, string>(x => x % 2 == 0 ? "Even" : "Odd");
            Console.WriteLine(evenOddChecker(number));



            //Use a lambda expression to compare two strings based on their lengths.

            Console.WriteLine("Enter the first string:");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string secondString = Console.ReadLine();

            var stringComparer = new Func<string, string, string>((x, y) => x.Length > y.Length ? x : y);
            Console.WriteLine(stringComparer(firstString, secondString));
        }
    }
}
