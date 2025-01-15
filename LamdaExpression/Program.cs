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
            foreach (var num in evenNumber)
            {
                Console.WriteLine(num);
            }


            int[] array = { 1, 2, 3, 3, 2, 3, 4, 5, 4, 5 };
            var distinceNum = array.Distinct();
            Console.WriteLine(string.Join(", ", distinceNum));

            var listNum = new List<int>() { 1,5,4,6,3,2,8,9 };
            var evenNum = listNum.Where(x => x % 2 == 0);
            var oddNum = listNum.Where(x => x % 2 == 1);
            Console.WriteLine("Even number:" + string.Join(" ", evenNum) + "\nOdd numbar: " + string.Join(" ", oddNum));


            var acendingNum = listNum.OrderBy(x => x);
            var descendingNum = listNum.OrderByDescending(x => x);
            Console.WriteLine("Acending Order: " + string.Join(" ", acendingNum) + "\nDescending ordere: " + string.Join(" ", descendingNum));

            var list = new List<int>() { };
            var first = listNum.FirstOrDefault();
            var second = list.FirstOrDefault();
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));


            var takeNum = listNum.Take(3);
            var skipNum = listNum.Skip(2);

            Console.WriteLine("Take element is: " + string.Join(" ", takeNum));
            Console.WriteLine("Take element is: " + string.Join(" ", skipNum));
        }
    }
}
