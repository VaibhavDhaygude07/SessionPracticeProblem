using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem
{
    internal class NumberTransformation
    {
        public static void Transformation()
        {
            //Given a list of integers, use a lambda expression to:
            //Multiply each number by 2.
            //Remove numbers less than 10.

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result1 = numbers.Select(x => x * 2);
            var Result2 = result1.Where(x => x > 10);
            foreach (var item in Result2)
            {
                Console.WriteLine(item);
            }

            //Write a lambda expression to find the maximum of two numbers.
            var max = new Func<int, int, int>((x, y) => x > y ? x : y);
            Console.WriteLine(max(10, 20));

        }
    }
}
