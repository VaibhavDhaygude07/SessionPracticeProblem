using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    
    internal class Program
    {
        public static void DictionaryPractice()
        {
            Dictionary<int, string> GenericDict = new Dictionary<int, string>();
            GenericDict.Add(1, "Orange");
            GenericDict.Add(2, "Banana");
            GenericDict.Add(3, "Mango");
            GenericDict.Add(4, "Lemon");
            GenericDict.Add(5, "Apple");

            foreach (KeyValuePair<int, string> element in GenericDict)
            {
                Console.WriteLine(element.Key + " " + element.Value);
            }
        }

        public static void List()
        {
            List<int> GenericList = new List<int>();

            GenericList.Add(30);

            GenericList.Add(60);

            GenericList.Add(90);

            GenericList.Add(120);

            foreach (int x in GenericList)

            {

                Console.WriteLine(x);

            }
        }

        public static void ArrayList()
        {
            ArrayList array = new ArrayList();
            string str = "abc xyz";
            int x = 7;
            DateTime d = DateTime.Now;
            array.Add(str);
            array.Add(x);
            array.Add(d);

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "abc");
            ht.Add(2, "xyz");
            ht.Add(3, "abc");
            ht.Add(1, "bxfds");

            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }

        public static void SortedListPrac()
        {
            SortedList sl = new SortedList();
            sl.Add(5, "Burger");
            sl.Add(6, "Soda");
            sl.Add(1, "Fries");
            sl.Add(2, "Rings");
            sl.Add(8, "oil");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }

        public static void StackPrac()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(8);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            DictionaryPractice();
            List();
            ArrayList();
            HashTable();
            SortedListPrac();
            StackPrac();
            
     

        }
       
    }
}
