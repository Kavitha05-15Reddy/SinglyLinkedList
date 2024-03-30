using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();    
            l.InsertB(1);
            l.InsertB(2);
            l.InsertE(3);
            l.InsertE(4);
            l.Remove(2);
            l.Display();
        }
    }
}
