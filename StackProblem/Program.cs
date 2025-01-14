using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    internal class Stack
    {
        private int[] elements;
        private int top;
        private int maxSize;



        public void StackValue(int size)
        {
            size = 5;
            maxSize = size;
            elements = new int[maxSize];
            top = 0;
        }

        public void push(int data)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            elements[++top] = data;
            Console.WriteLine(data + " pushed to stack");

        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");

            }
            return elements[top--];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(5);
            stack.push(8);
            stack.push(4);
            stack.push(9);
            stack.Pop();


        }
    }
}
