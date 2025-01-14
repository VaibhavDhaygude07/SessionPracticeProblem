using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> GenericList = new List<int>();

            GenericList.Add(30);

            GenericList.Add(60);

            GenericList.Add(90);

            GenericList.Add(120);

            GenericList.Remove(60);

            foreach (int x in GenericList)
            {
                Console.WriteLine(x);
            }


        }
    }
}
