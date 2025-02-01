using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    internal class StackImplementation
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

        public int Push(int data)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack Overflow");
                return -1;
            }
            elements[top++] = data;
            Console.WriteLine(data + " pushed to stack");
            return data;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");

            }
            return elements[top--];
        }
        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            return elements[top];
        }


        public static void Stack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(8);
            stack.Push(4);
            stack.Push(9);
            stack.Pop();
            stack.Peek();

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

        }
        
}
}

