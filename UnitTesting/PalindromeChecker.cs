using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class PalindromeChecker
    {
            
        public bool Palindrom(string str)
        {
            string temp = str;

            string reverse="";

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reverse += temp[i];
            }

            if (str == temp)
            {
                Console.WriteLine("String is palindrom");
                return true;
            }
            else
            {
                return false;
            }

        }

        
        
    }
}
