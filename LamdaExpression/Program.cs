using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = num => num * num;
            Console.WriteLine("Squar of number is: " + square(8));

            int[] number = { 3, 2, 4, 5, 3, 4, 3, 5, 4, 2, 3 };
            int totalCount = number.Count(x => x == 3);
            Console.WriteLine("total number of 3 present:" + totalCount);

            var evenNumber = number.Where(num => num % 2 == 0);
            Console.WriteLine("Enven number: ");
            foreach(var num in evenNumber)
            {
                Console.WriteLine(num);
            }
        }
    }
}
