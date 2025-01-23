using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOJson
{   
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{RollNo=1, Name="Joshep",Subject="Physics"},
                new Student{RollNo=2, Name="Harry",Subject="Math"},
                new Student{RollNo=3, Name="Smeeth",Subject="Chemistry"},
                new Student{RollNo=4, Name="Devid",Subject="Biology"},
                new Student{RollNo=5, Name="Josh",Subject="Histry"}

            };

            string path = @"C:\Users\aksha\Downloads\C# Program\bridgelabzSessionProblems\FileOPJson\studentInfo.json";
            File.Create(path);
            string jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(path, jsonData);

            //Read daa
            string readJson = File.ReadAllText(path);
            var deserializedJson = JsonConvert.DeserializeObject<List<Student>>(readJson);
            foreach(var student in deserializedJson)
            {
                Console.WriteLine($"Id: {student.RollNo}, Name: {student.Name}, Subject: {student.Subject}");
            }
        }
    }
}
