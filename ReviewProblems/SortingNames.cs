using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class SortingNames
    {
        public static void Sorting()
        {
            //Use a C# collection like List<T> to store a list of names. 
            //Sort them alphabetically without using built-in sorting methods.

            List<string> names = new List<string> { "John", "Devid", "Jane", "Smith", "Alex", "james" };

            for (int i = 0; i < names.Count; i++)
            {
                for (int j = i + 1; j < names.Count; j++)
                {
                    if (names[i].CompareTo(names[j]) > 0)
                    {
                        string temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;
                    }
                }
            }
            foreach(var i in names)
            {
                Console.WriteLine(i);
            }

        }
    }
}
