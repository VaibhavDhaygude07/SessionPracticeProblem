using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinArray
{
    class MaxMinArray
    {
        public void Array()
        {
            int[] intArray = { 1, 2, 4, 6, 3, 4, 5 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'v' };
            double[] doubleArray = { 1.1, 2.5, 3.8, 8.6 };

            ToFindMax(intArray);
            ToFindMax(charArray);
            ToFindMax(doubleArray);


        }

        public void ToFindMax<T>(T[] array)
        {
            dynamic max = array[0];
            dynamic min = array[0];
            foreach(T element in array)
            {
                if(element > max)
                {
                    max = element;
                }
            }
           Console.Write("Max value of array is: "+ max);

            foreach(T element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            Console.WriteLine("   Min value of array is: " + min);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxMinArray findMaxMin = new MaxMinArray();
            findMaxMin.Array();
            
        }
    }
}
