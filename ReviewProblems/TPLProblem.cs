using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class TPLProblem
    {
        public static async Task TPL()
        {
            //Use TPL to perform three independent operations in parallel:
            //Write numbers to a file.
            //Calculate the sum of an array.
            //Sort a list of strings.

            int[] numbers = new int[] { 10, 20, 30, 40, 50 };
           
            List<string> names = new List<string> { "John", "Alice", "Bob", "Charlie", "Eve" };

            

            Task<int> task1 = Task.Run(() => CalculateSum(numbers));

            Task task2 = Task.Run(() => SortList(names));

            Task.WhenAll( task1, task2);

          
            Console.WriteLine("Sum of the array: " + task1.Result);

        }
        
        static int CalculateSum(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }

        static void SortList(List<string> names)
        {
            names.Sort();
            Console.WriteLine("Sorted names: " + string.Join(", ", names));
        }

    }
}
