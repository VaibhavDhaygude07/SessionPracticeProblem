using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Session_Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that counts the occurrences of a specific character in a list of
            //strings using a lambda expression.
            var stringList = new List<string>() { "mumbai", "pune", "maharastra", "abc" };
            var targetchar = 'a';
            var stringCount = stringList.Sum(s => s.Count(c => c == targetchar));
            Console.WriteLine(stringCount);



            //Write a program that performs various aggregate operations (sum, average, minimum, maximum)
            //on a list of numbers using lambda expressions.
            var arrList = new List<int>() { 1, 2, 3, 4, 5 };
            var arraySum = arrList.Sum(x => x);
            var arrAverage = arrList.Average(x => x);
            var arrMinimum = arrList.Min(x => x);
            var arrMaximum = arrList.Max(x => x);
            Console.WriteLine("sum: " + arraySum + "\nAverage: " + arrAverage + "\nMininum value: " + arrMinimum + "\nMaximum value: " + arrMaximum);


            //Write a program that finds all words in a list that start with the letter 'A' using LINQ.
            var strList = new List<string>() { "Aabc", "Wxyz", "Asdf", "Ydfedd" };
            var resultLetter = from y in strList
                               where y.StartsWith("A")
                               select y;

            foreach (var result in resultLetter)
            {
                Console.WriteLine(result);
            }


            //Write a program that finds the top 3 highest scores from a list of integers using LINQ.
            var arrList1 = new List<int>() { 1, 2, 3, 4, 5 };
            var highestScore = arrList1.OrderByDescending(score => score).Take(3);
            foreach (var result in highestScore)
            {
                Console.WriteLine(result);
            }


            //Write a program that groups a list of Person objects by their age using LINQ.

            List<Person> people = new List<Person>
            {
                new Person {name="Vaibhav", age=22},
                new Person {name="Ramesh",age=24},
                new Person {name="Vishal", age=22},
                new Person {name="Vikas", age=22},
                new Person {name="Prakash", age=24},
                new Person {name="Aash", age=25}
            };

            var groupBy = from Person in people
                          group Person by Person.age into ageGroup
                          select ageGroup;

            foreach(var group in groupBy)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"Name: {person.name}");
                }
            }

        }
        class Person
        {
            public string name { get; set; }
            public int age { get; set; }
        }

    }
}
