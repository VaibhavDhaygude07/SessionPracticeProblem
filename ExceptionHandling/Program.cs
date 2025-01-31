using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
             Console.WriteLine("Enter first number: ");
             num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter second number");
             num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num2 % 2 > 0) 
                {
                    throw new Exception();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //throw e;
            }

            int div = num1 / num2;




            int[] arr = new int[5];
            Console.WriteLine("Enter the element of array: ");
            int length = arr.Length;
           

            for (int i = 0; i < length; i++)
            {
                try
                {
                    string arrayInput = Console.ReadLine();
                    arr[i] = Convert.ToInt32(arrayInput);


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }

            }
            Console.WriteLine("Prime number: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
