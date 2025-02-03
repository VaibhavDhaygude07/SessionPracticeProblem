using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticeProblem
{
    internal class PracticeProblem
    {
        public static void Linq()
        {
            //Write a program in C# Sharp to show how the three parts of a query operation execute.
            //Expected Output:
            //The numbers which produce the remainder 0 after divided by 2 are:
            //0 2 4 6 8

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = from num in numbers
                         where num % 2 == 0
                         select num;
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
