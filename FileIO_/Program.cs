using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_
{
    class Employee
    {
        public string name { get; set; }
        public string EMail { get; set; }
        public int age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> records = new List<Employee>
            {
                new Employee {name="Devid", EMail="devid@gmail.com", age=38},
                new Employee {name="Jon",   EMail="jon@gmail.com", age=28},
                new Employee {name="Carry", EMail="carry@gmail.com", age=26},
                new Employee {name="jemes", EMail="jemes@gmail.com", age=30},
                new Employee {name="Kevin", EMail="kevin@gmail.com", age=42},
                new Employee {name="Abraham", EMail="abd@gmail.com", age=25}
            };
            string path = @"C:\Users\aksha\Downloads\C# Program\bridgelabzSessionProblems\FileIO_\records.csv";
            //File.Create(path);
            using (var writer = new StreamWriter(path))
            using (var csvWrite = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWrite.WriteRecords(records);
            }
            Console.WriteLine("Data added to csv file");



            using (var reader = new StreamReader(path))
                using(var csvRead = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var readData = csvRead.GetRecords<Employee>();
                foreach(var record in readData)
                {
                    Console.WriteLine($"Name {record.name}, Email {record.EMail}, Age {record.age}");
                }
            }
        }
    }
}
