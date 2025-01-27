using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblem
{
    internal class GenericMethodforSwapping
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static void Swapping()
        {
            int a = 10;
            int b = 20;

            Swap<int>(ref a, ref b);
            Console.WriteLine(" a " + a + " b " + b);
        }
    }
}
