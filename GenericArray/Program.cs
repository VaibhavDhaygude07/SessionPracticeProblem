using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArray
{
    internal class GenericArray
    {
        public void Array()
        {
            int[] intarray = { 1, 2, 3, 4, 5, 6, 7 };
            char[] chararray = { 'a', 'b', 'c', 'd' };
            double[] doublearray = { 1.1, 2.1, 3.5, 5.1 };
            string[] stringarray = { "vaibhav", "abc", "xyz", "qwer" };

            
            ToPrintArray(intarray);
            ToPrintArray(chararray);
            ToPrintArray(doublearray);
            ToPrintArray(stringarray);
        }

        public static void ToPrintArray<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.WriteLine(element + " ");
            }
        }
    }
    internal class Program
    {
         static void Main(string[] args)
        {
            GenericArray genericArray = new GenericArray();
            genericArray.Array();
        }
    }
}
