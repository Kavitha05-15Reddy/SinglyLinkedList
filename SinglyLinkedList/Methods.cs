using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
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
        private Node head;
        public LinkedList()
        {
            head=null;
        }
        public void InsertB(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }
        public void InsertE(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head=newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Remove(int data)
        {
            if (head == null)
            {
                return;
            }
            if (head.Data == data)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                if(current.Next.Data == data)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
