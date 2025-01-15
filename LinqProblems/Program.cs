using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 5, 4, 6, 46, 8, 9 };
            var resultNum = from y in numbers
                            where y % 2 == 0
                            select y;
            foreach (var result in resultNum)
            {
                Console.WriteLine(result);
            }

            var methodSyntax = numbers.Where(whr => whr>2);


            string[] stringArray = new string[] { "mumbai", "Pune", "Chennai", "Hydrabad" };
            var resultStr = from z in stringArray
                            where z.Length > 5
                            orderby z 
                            select z;
            foreach(var result in resultStr)
            {
                Console.WriteLine(result);
            }
        }
    }
}
