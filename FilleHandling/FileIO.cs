using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilleHandling
{
    internal class FileIO
    {
        public static void ReadText()
        {
            string path = @"C:\Users\aksha\Downloads\FileHandling_\Prac_FileHandling\file.txt";

            Console.WriteLine("Contents of file: ");
            string read = File.ReadAllText(path);
            Console.WriteLine(read);

        }
        public static void WriteText()
        {
            string path = @"C:\Users\aksha\Downloads\FileHandling_\Prac_FileHandling\file.txt";

            Console.WriteLine("Enter the text you want to write in the file");
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
            Console.WriteLine("Data successfully written");

        }

        public static void AppendText()
        {

            string path = @"C:\Users\aksha\Downloads\FileHandling_\Prac_FileHandling\file.txt";
            string appendText = "Hello";
            File.AppendAllText(path, appendText);
            Console.WriteLine("Text appended");

        }

        public static void CountWords()
        {
            string path = @"C:\Users\aksha\Downloads\FileHandling_\Prac_FileHandling\file.txt";
            string content = File.ReadAllText(path);
            int count = content.Split(' ').Length;
            Console.WriteLine($"There are {count} words");
        }

        

        
    }
}
