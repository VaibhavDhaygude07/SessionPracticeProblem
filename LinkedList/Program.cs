using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DsaProblem
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }


    public class LinkedList
    {
        private Node Head;

        public void AddAfterTail(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void AddFront(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }


        }
        public void Delete(int data)
        {
            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }
            Node current = Head;
            Node previous = null;

            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Node with value " + data + "not found.");
                return;
            }


            previous.Next = current.Next;
        }
        public void Traverse()
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty");
                return;

            }

            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + "  ");
                current = current.Next;
            }

        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddAfterTail(40);
            list.AddAfterTail(50);
            list.AddAfterTail(60);

            list.AddFront(30);
            list.AddFront(20);
            list.AddFront(10);

            list.Delete(40);

            list.Traverse();

        }
    }
}
